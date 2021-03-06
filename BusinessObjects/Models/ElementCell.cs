namespace forCrowd.WealthEconomy.BusinessObjects
{
    using forCrowd.WealthEconomy.BusinessObjects.Attributes;
    using forCrowd.WealthEconomy.Framework;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    [DisplayName("Element Cell")]
    [forCrowd.WealthEconomy.BusinessObjects.Attributes.DefaultProperty("Id")]
    // [ODataControllerAuthorization("Administrator")]
    public class ElementCell : BaseEntity
    {
        [Obsolete("Parameterless constructors used by OData & EF. Make them private when possible.")]
        public ElementCell()
        {
            UserElementCellSet = new HashSet<UserElementCell>();
        }

        public ElementCell(ElementField field, ElementItem item)
            : this()
        {
            Validations.ArgumentNullOrDefault(field, "field");
            Validations.ArgumentNullOrDefault(item, "item");

            ElementField = field;
            ElementItem = item;
        }

        [DisplayOnListView(false)]
        [DisplayOnEditView(false)]
        [Display(Name = "Element Cell Id")]
        public int Id { get; set; }

        [Index("IX_ElementCellId", 1, IsUnique = true)]
        public int ElementFieldId { get; set; }

        [Index("IX_ElementCellId", 2, IsUnique = true)]
        public int ElementItemId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string StringValue { get; private set; }

        // TODO Doesn't have to be nullable but it requires a default value then which needs to be done
        // by manually editing migration file which is not necessary at the moment / SH - 03 Aug. '15
        [DisplayOnListView(false)]
        [DisplayOnEditView(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? NumericValueTotal { get; private set; }

        // TODO Doesn't have to be nullable but it requires a default value then which needs to be done
        // by manually editing migration file which is not necessary at the moment / SH - 03 Aug. '15
        [DisplayOnListView(false)]
        [DisplayOnEditView(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? NumericValueCount { get; private set; }

        /// <summary>
        /// In case this cell's field type is Element, this is the selected item for this cell.
        /// Other values are stored on UserElementCell, but since this one has FK, it's directly set on ElementCell.
        /// </summary>
        [Display(Name = "Selected Element Item")]
        public int? SelectedElementItemId { get; set; }

        public virtual ElementItem ElementItem { get; set; }
        public virtual ElementField ElementField { get; set; }
        public virtual ElementItem SelectedElementItem { get; set; }
        public virtual ICollection<UserElementCell> UserElementCellSet { get; set; }

        public UserElementCell UserElementCell
        {
            get { return UserElementCellSet.SingleOrDefault(); }
        }

        #region - Methods -

        public ElementCell ClearValue()
        {
            return ClearValue(null);
        }

        public ElementCell ClearValue(User user)
        {
            FixedValueValidation(user);

            var fixedValue = ElementField.UseFixedValue.GetValueOrDefault(true);
            if (fixedValue)
                ClearFixedValues();
            else
                RemoveUserCell(user);

            return this;
        }

        public ElementCell SetValue(string value)
        {
            SetValueHelper(ElementFieldDataType.String, null);
            GetUserCell().SetValue(value);
            return this;
        }

        public ElementCell SetValue(bool value)
        {
            SetValueHelper(ElementFieldDataType.Boolean, null);
            GetUserCell().SetValue(value);
            return this;
        }

        public ElementCell SetValue(int value)
        {
            SetValueHelper(ElementFieldDataType.Integer, null);
            GetUserCell().SetValue(value);
            return this;
        }

        public ElementCell SetValue(decimal value)
        {
            SetValueHelper(ElementFieldDataType.Decimal, null);
            GetUserCell().SetValue(value);
            return this;
        }

        public ElementCell SetValue(DateTime value)
        {
            SetValueHelper(ElementFieldDataType.DateTime, null);
            GetUserCell().SetValue(value);
            return this;
        }

        public ElementCell SetValue(ElementItem value)
        {
            SetValueHelper(ElementFieldDataType.Element, null);
            SelectedElementItem = value;
            return this;
        }

        void SetValueHelper(ElementFieldDataType valueType, User user)
        {
            // Validations

            // a. Field and value type
            var fieldType = (ElementFieldDataType)ElementField.DataType;

            // 1. Field's type & this operation's type has to match
            // 2. And if field type is DirectIncome or Multiplier, value type has to be Decimal
            if (fieldType != valueType
                && !(fieldType == ElementFieldDataType.DirectIncome
                || fieldType == ElementFieldDataType.Multiplier
                    && valueType == ElementFieldDataType.Decimal))
                throw new InvalidOperationException(string.Format("Invalid value, field and value types don't match - Field type: {0}, Value type: {1}",
                    fieldType,
                    valueType));

            // b. FixedValue
            //FixedValueValidation(user);

            // Clear, if FixedValue
            var fixedValue = ElementField.UseFixedValue.GetValueOrDefault(true);
            if (fixedValue)
                ClearFixedValues();
        }

        void FixedValueValidation(User user)
        {
            var fixedValue = ElementField.UseFixedValue.GetValueOrDefault(true);
            if (!fixedValue && user == null)
                throw new InvalidOperationException("Value can't be set without user parameter when FixedValue is false");
        }

        void ClearFixedValues()
        {
            //StringValue = null;
            //BooleanValue = null;
            //IntegerValue = null;
            //DecimalValue = null;
            //DateTimeValue = null;
            // TODO Do we need to set both?
            SelectedElementItemId = null;
            SelectedElementItem = null;
        }

        UserElementCell AddUserCell()
        {
            // Validations.ArgumentNullOrDefault(user, "user");

            //if (UserElementCellSet.Any(item => item.User == user))
            if (UserElementCell != null)
                throw new Exception("An element cell can't have more than one user element cell for the same user.");

            var userCell = new UserElementCell(this);

            if (userCell.User != null)
                userCell.User.UserElementCellSet.Add(userCell);
            //user.UserElementCellSet.Add(userCell);
            UserElementCellSet.Add(userCell);
            return userCell;
        }

        ElementCell RemoveUserCell(User user)
        {
            Validations.ArgumentNullOrDefault(user, "user");

            var userCell = UserElementCellSet.SingleOrDefault(item => item.User == user);
            if (userCell != null)
            {
                user.UserElementCellSet.Remove(userCell);
                UserElementCellSet.Remove(userCell);
            }
            return this;
        }

        UserElementCell GetUserCell()
        {
            // Validations.ArgumentNullOrDefault(user, "user");

            // var userCell = UserElementCellSet.SingleOrDefault(item => item.User == user);
            var userCell = UserElementCell;
            if (userCell == null)
                userCell = AddUserCell();

            return userCell;
        }

        UserElementCell GetUserCell(User user)
        {
            Validations.ArgumentNullOrDefault(user, "user");

            // var userCell = UserElementCellSet.SingleOrDefault(item => item.User == user);
            var userCell = UserElementCell;
            if (userCell == null)
                userCell = AddUserCell();

            return userCell;
        }

        #endregion
    }
}
