﻿/// <reference path="Commons.js" />

describe('ng Cell', function () {

    var ResourcePool, Element, ElementField, ElementItem, ElementCell;

    beforeEach(module('main'));

    beforeEach(function () {
        inject(function ($injector) {

            ResourcePool = $injector.get('ResourcePool');
            Element = $injector.get('Element');
            ElementField = $injector.get('ElementField');
            ElementItem = $injector.get('ElementItem');
            ElementCell = $injector.get('ElementCell');
            UserElementCell = $injector.get('UserElementCell');

            registerPrototypes($injector);

        });
    });

    function createResourcePool(addMultiplierField) {
        addMultiplierField = typeof addMultiplierField === 'undefined' ? false : addMultiplierField;

        // ResourcePool
        var resourcePool = new ResourcePool();

        // Element
        var element = new Element();
        element.ResourcePool = resourcePool;
        element.IsMainElement = true;
        resourcePool.ElementSet = [element];

        // Decimal field
        var decimalField = new ElementField();
        decimalField.Element = element;
        decimalField.DataType = 4;
        element.ElementFieldSet = [decimalField];

        // Item
        var item = createItem(element);

        // Decimal cell
        createCell(decimalField, item);

        // Multiplier field & cell & userCell?
        if (addMultiplierField) {
            var multiplierField = new ElementField();
            multiplierField.Element = element;
            multiplierField.DataType = 12;
            element.ElementFieldSet.push(multiplierField);

            var multiplierCell = new ElementCell();
            multiplierCell.ElementField = multiplierField;
            multiplierCell.ElementItem = item;
            multiplierField.ElementCellSet = [multiplierCell];
            item.ElementCellSet.push(multiplierCell);

            var userMultiplierCell = new UserElementCell();
            userMultiplierCell.ElementCell = multiplierCell;
            userMultiplierCell.DecimalValue = 1;
            multiplierCell.UserElementCellSet = [userMultiplierCell];
            //multiplierCell.CurrentUserCell = userMultiplierCell;
        }

        // Return
        return resourcePool;
    }

    function createItem(element) {

        var item = new ElementItem();
        item.Element = element;

        if (element.ElementItemSet.length === 0) {
            element.ElementItemSet = [item];
        } else {
            element.ElementItemSet.push(item);
        }

        return item;
    }

    function createCell(field, item) {

        var cell = new ElementCell();
        cell.ElementField = field;
        cell.ElementItem = item;

        if (field.ElementCellSet.length === 0) {
            field.ElementCellSet = [cell];
        } else {
            field.ElementCellSet.push(cell);
        }

        if (item.ElementCellSet.length === 0) {
            item.ElementCellSet = [cell];
        } else {
            item.ElementCellSet.push(cell);
        }

        return cell;
    }

    function createUserCell(cell, rating) {

        var userCell = new UserElementCell();
        userCell.ElementCell = cell;
        userCell.DecimalValue = rating;
        cell.UserElementCellSet = [userCell];

        // TODO Manually update?!
        cell.setCurrentUserNumericValue();
    }

    // TODO removeUserCell function and related tests?

    it('userCell - Initial', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];

        expect(cell.currentUserCell()).toBe(null);
    });

    it('userCell - With user cell', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];

        // Add user cell
        createUserCell(cell, 10);
        var userCell = cell.UserElementCellSet[0];

        // Assert
        expect(cell.currentUserCell()).toBe(userCell);

    });

    it('currentUserNumericValue - Initial', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];

        expect(cell.currentUserNumericValue()).toBe(50);
    });

    it('currentUserNumericValue - With user cell', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];

        // Add user cell
        createUserCell(cell, 10);
        var userCell = cell.UserElementCellSet[0];

        // Assert
        expect(cell.currentUserNumericValue()).toBe(10);
    });

    it('otherUsersNumericValueTotal - Initial', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];

        expect(cell.otherUsersNumericValueTotal()).toBe(0);
    });

    it('otherUsersNumericValueTotal - Without user rating', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueTotal = 25;

        expect(cell.otherUsersNumericValueTotal()).toBe(25);
    });

    it('otherUsersNumericValueTotal - With user rating', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueTotal = 25;
        createUserCell(cell, 10);

        expect(cell.otherUsersNumericValueTotal()).toBe(15);
    });

    it('otherUsersNumericValueCount - Initial', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];

        expect(cell.otherUsersNumericValueCount()).toBe(0);
    });

    it('otherUsersNumericValueCount - Without user rating', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueCount = 3;

        expect(cell.otherUsersNumericValueCount()).toBe(3);
    });

    it('otherUsersNumericValueCount - With user rating', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueCount = 3;
        createUserCell(cell, 10);

        expect(cell.otherUsersNumericValueCount()).toBe(2);
    });

    it('numericValueTotal - Initial', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];

        expect(cell.numericValueTotal()).toBe(50);
    });

    it('numericValueTotal - Without user rating', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueTotal = 25;

        expect(cell.numericValueTotal()).toBe(25 + 50);
    });

    it('numericValueTotal - Including user rating', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueTotal = 25;
        createUserCell(cell, 10);

        expect(cell.numericValueTotal()).toBe(25);
    });

    it('numericValueTotal - Adding user rating', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueTotal = 25;

        // Since it needs to calculate the current value (without user cell), call it once
        // TODO This wouldn't be necessary if the server could calculate it and send?
        cell.numericValueTotal();

        // Act
        createUserCell(cell, 10);

        // This has to be called manually in order to update the cached value
        // In the application, this is done by updateElementCellNumericValue method under userService.js
        cell.setCurrentUserNumericValue();

        // Assert
        expect(cell.numericValueTotal()).toBe(25 + 10);
    });

    it('numericValueCount - Initial', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];

        expect(cell.numericValueCount()).toBe(1);
    });

    it('numericValueCount - Without user rating', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueCount = 3;

        expect(cell.numericValueCount()).toBe(3 + 1);
    });

    it('numericValueCount - Including user rating', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueCount = 3;
        createUserCell(cell, 10);

        expect(cell.numericValueCount()).toBe(3);
    });

    it('numericValueCount - Adding user rating', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueCount = 3;

        // Since it needs to calculate the current value (without user cell), call it once
        // TODO This wouldn't be necessary if the server could calculate it and send?
        cell.numericValueCount();

        // Act
        createUserCell(cell, 10);

        // Assert
        expect(cell.numericValueCount()).toBe(3 + 1);
    });

    it('numericValueAverage', function () {

        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueTotal = 75;
        cell.NumericValueCount = 3;

        expect(cell.numericValueAverage()).toBe((75 + 50) / (3 + 1));
    });

    it('numericValue', function () {

        // Arrange & act - Case 1: RatingMode 1 (Default)
        var resourcePool = createResourcePool();
        var cell = resourcePool.mainElement().ElementFieldSet[0].ElementCellSet[0];
        cell.NumericValueTotal = 75;
        cell.NumericValueCount = 3;

        // Assert
        expect(cell.numericValue()).toBe(cell.currentUserNumericValue());

        // Act -  Cast 2: RatingMode 2 & also cache case
        resourcePool.RatingMode = 2;

        // Assert
        expect(cell.numericValue()).toBe(cell.numericValueAverage());
    });

    it('numericValueMultiplied - Without multiplierCell', function () {

        var resourcePool = createResourcePool();
        var field = resourcePool.mainElement().ElementFieldSet[0];
        var cell = field.ElementCellSet[0];

        expect(cell.numericValueMultiplied()).toBe(50 * 1);
    });

    it('numericValueMultiplied - With multiplierCell', function () {

        var resourcePool = createResourcePool(true);
        var field = resourcePool.mainElement().ElementFieldSet[0];
        var item = resourcePool.mainElement().ElementItemSet[0];
        var cell = field.ElementCellSet[0];

        expect(cell.numericValueMultiplied()).toBe(cell.numericValue() * item.multiplier());

        // Case 2: Cached value
        // TODO Actually this case belongs to ElementItemTests.js - setMultiplier() test?
        var userMultiplierCell = resourcePool.mainElement().ElementFieldSet[1].ElementCellSet[0].UserElementCellSet[0];
        userMultiplierCell.DecimalValue = 5;

        // TODO Manually update?!
        item.setMultiplier();
        cell.setNumericValueMultiplied();

        expect(cell.numericValueMultiplied()).toBe(cell.numericValue() * item.multiplier());
    });

    it('numericValueMultipliedPercentage - !IndexEnabled', function () {

        var resourcePool = createResourcePool();
        var field = resourcePool.mainElement().ElementFieldSet[0];
        var cell = field.ElementCellSet[0];

        expect(cell.numericValueMultipliedPercentage()).toBe(0);
    });

    it('numericValueMultipliedPercentage - IndexEnabled, One Item', function () {

        var resourcePool = createResourcePool();
        var field = resourcePool.mainElement().ElementFieldSet[0];
        field.IndexEnabled = true;
        var cell = field.ElementCellSet[0];

        expect(cell.numericValueMultipliedPercentage()).toBe(1);
    });

    it('numericValueMultipliedPercentage - IndexEnabled, Two Items', function () {

        var resourcePool = createResourcePool();
        var element = resourcePool.mainElement();

        var field = element.ElementFieldSet[0];
        field.IndexEnabled = true;

        var cell1 = field.ElementCellSet[0];
        createUserCell(cell1, 55);

        var item2 = createItem(element);
        var cell2 = createCell(field, item2);
        createUserCell(cell2, 45);

        expect(cell1.numericValueMultipliedPercentage()).toBe(55 / (45 + 55));
        expect(cell2.numericValueMultipliedPercentage()).toBe(45 / (45 + 55));
    });

    it('aggressiveRating - !IndexEnabled', function () {

        var resourcePool = createResourcePool();

        var field = resourcePool.mainElement().ElementFieldSet[0];
        var cell = field.ElementCellSet[0];

        expect(cell.aggressiveRating()).toBe(0);
    });

    it('aggressiveRating - RatingSortType 1 (Def.), One Item', function () {

        var resourcePool = createResourcePool();
        var field = resourcePool.mainElement().ElementFieldSet[0];
        field.IndexEnabled = true;
        field.IndexSortType = 2;
        var cell = field.ElementCellSet[0];

        expect(cell.aggressiveRating()).toBe(1);
    });

    it('aggressiveRating - RatingSortType 1 (Def.), Two Items', function () {

        var resourcePool = createResourcePool();
        var element = resourcePool.mainElement();

        var field = element.ElementFieldSet[0];
        field.IndexEnabled = true;
        field.IndexSortType = 2;

        var cell1 = field.ElementCellSet[0];
        createUserCell(cell1, 55);

        var item2 = createItem(element);
        var cell2 = createCell(field, item2);
        createUserCell(cell2, 45);

        expect(cell1.aggressiveRating()).toBe(1 - (cell1.numericValueMultiplied() / field.referenceRatingMultiplied()));
        expect(cell2.aggressiveRating()).toBe(1 - (cell2.numericValueMultiplied() / field.referenceRatingMultiplied()));
    });

    it('aggressiveRating - IndexSortType 1, One Item', function () {

        var resourcePool = createResourcePool();
        var field = resourcePool.mainElement().ElementFieldSet[0];
        field.IndexSortType = 1;
        field.IndexEnabled = true;
        var cell = field.ElementCellSet[0];

        //expect(cell.aggressiveRating()).toBe(1);
        expect(cell.aggressiveRating()).toBe(0);
    });

    it('aggressiveRating - IndexSortType 1, Two Items', function () {

        var resourcePool = createResourcePool();
        var element = resourcePool.mainElement();

        var field = element.ElementFieldSet[0];
        field.IndexSortType = 1;
        field.IndexEnabled = true;

        var cell1 = field.ElementCellSet[0];
        createUserCell(cell1, 55);

        var item2 = createItem(element);
        var cell2 = createCell(field, item2);
        createUserCell(cell2, 45);

        expect(cell1.aggressiveRating()).toBe(1 - ((1 - cell1.numericValueMultipliedPercentage()) / field.referenceRatingMultiplied()));
        expect(cell2.aggressiveRating()).toBe(1 - ((1 - cell2.numericValueMultipliedPercentage()) / field.referenceRatingMultiplied()));
    });

    // TODO rating tests!

    it('ratingPercentage', function () {

        var resourcePool = createResourcePool();
        var element = resourcePool.mainElement();

        var field = element.ElementFieldSet[0];
        field.IndexEnabled = true;
        field.IndexCalculationType = 1;
        field.IndexSortType = 2;

        var cell1 = field.ElementCellSet[0];
        createUserCell(cell1, 55);

        var item2 = createItem(element);
        var cell2 = createCell(field, item2);
        createUserCell(cell2, 45);

        expect(cell1.ratingPercentage()).toBe(cell1.rating() / field.rating());
        expect(cell2.ratingPercentage()).toBe(cell2.rating() / field.rating());
    });

    it('indexIncome', function () {

        var resourcePool = createResourcePool();
        var element = resourcePool.mainElement();

        var field = element.ElementFieldSet[0];
        field.DataType = 11; // DirectIncome field type
        field.IndexEnabled = true;

        var cell1 = field.ElementCellSet[0];
        cell1.NumericValueTotal = 55;

        var item2 = createItem(element);
        var cell2 = createCell(field, item2);
        cell2.NumericValueTotal = 45;

        expect(cell1.indexIncome()).toBe(field.indexIncome() * cell1.ratingPercentage());
        expect(cell2.indexIncome()).toBe(field.indexIncome() * cell2.ratingPercentage());
    });

});
