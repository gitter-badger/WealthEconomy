﻿namespace Facade.Tests
{
    using BusinessObjects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ResourcePoolTest
    {
        //#region - Total Cost Index -

        //[TestMethod]
        //public void SingleTotalCostIndex_SingleUser_TwoOrganizations()
        //{
        //    var resourcePool = new ResourcePool();

        //    var resourcePoolIndex = new ResourcePoolIndex() { ResourcePool = resourcePool, ResourcePoolIndexType = (byte)ResourcePoolIndexType.TotalCostIndex, RatingSortType = (byte)RatingSortType.LowestToHighest };
        //    resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex);

        //    var organization1 = new Organization() { ResourcePool = resourcePool, ProductionCost = 25, SalesPrice = 25 };
        //    resourcePool.OrganizationSet.Add(organization1);

        //    var organization2 = new Organization() { ResourcePool = resourcePool, ProductionCost = 75, SalesPrice = 75 };
        //    resourcePool.OrganizationSet.Add(organization2);

        //    var resourcePoolIndexOrganization1 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization1);
        //    var resourcePoolIndexOrganization2 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization2);

        //    var user = new User();

        //    var userResourcePool = new UserResourcePool() { User = user, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user.UserResourcePoolSet.Add(userResourcePool);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool);

        //    var userResourcePoolIndex = new UserResourcePoolIndex() { UserResourcePool = userResourcePool, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
        //    resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex);

        //    var userOrganization1 = new UserOrganization() { User = user, Organization = organization1, NumberOfSales = 1 };
        //    user.UserOrganizationSet.Add(userOrganization1);
        //    organization1.UserOrganizationSet.Add(userOrganization1);

        //    var userOrganization2 = new UserOrganization() { User = user, Organization = organization2, NumberOfSales = 1 };
        //    user.UserOrganizationSet.Add(userOrganization2);
        //    organization2.UserOrganizationSet.Add(userOrganization2);

        //    var userResourcePoolIndexOrganization1 = new UserResourcePoolIndexOrganization(userOrganization1, resourcePoolIndexOrganization1);
        //    var userResourcePoolIndexOrganization2 = new UserResourcePoolIndexOrganization(userOrganization2, resourcePoolIndexOrganization2);

        //    // Results
        //    Assert.IsTrue(resourcePool.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePool.ProductionCost == 100);
        //    Assert.IsTrue(resourcePool.Profit == 0);
        //    Assert.IsTrue(resourcePool.SalesPrice == 100);

        //    Assert.IsTrue(resourcePoolIndex.IndexRatingCount == 1);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingPercentage == 1);
        //    Assert.IsTrue(resourcePoolIndex.IndexValue == 100);

        //    Assert.IsTrue(organization1.Profit == 0);
        //    Assert.IsTrue(organization1.SalesPricePercentage == 0.25M);

        //    Assert.IsTrue(organization2.Profit == 0);
        //    Assert.IsTrue(organization2.SalesPricePercentage == 0.75M);

        //    Assert.IsTrue(userResourcePool.NumberOfSales == 2);
        //    Assert.IsTrue(userResourcePool.ResourcePoolTax == 100);
        //    Assert.IsTrue(userResourcePool.SalesPriceIncludingResourcePoolTax == 200);
        //    Assert.IsTrue(userResourcePool.TotalIncome == 100);
        //    Assert.IsTrue(userResourcePool.TotalProductionCost == 100);
        //    Assert.IsTrue(userResourcePool.TotalProfit == 0);
        //    Assert.IsTrue(userResourcePool.TotalResourcePoolTax == 100);
        //    Assert.IsTrue(userResourcePool.TotalSalesRevenue == 100);
        //    Assert.IsTrue(userResourcePool.TotalSalesRevenueIncludingResourcePoolTax == 200);

        //    Assert.IsTrue(userResourcePoolIndex.IndexShare == 100);
        //    Assert.IsTrue(userResourcePoolIndex.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization1.IndexIncome == 75);
        //    Assert.IsTrue(userOrganization1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1.ResourcePoolTax == 25);
        //    Assert.IsTrue(userOrganization1.SalesPriceIncludingResourcePoolTax == 50);
        //    Assert.IsTrue(userOrganization1.TotalIncome == 75);
        //    Assert.IsTrue(userOrganization1.TotalProductionCost == 25);
        //    Assert.IsTrue(userOrganization1.TotalProfit == 0);
        //    Assert.IsTrue(userOrganization1.TotalResourcePoolTax == 25);
        //    Assert.IsTrue(userOrganization1.TotalSalesRevenue == 25);
        //    Assert.IsTrue(userOrganization1.TotalSalesRevenueIncludingResourcePoolTax == 50);

        //    Assert.IsTrue(userOrganization2.IndexIncome == 25);
        //    Assert.IsTrue(userOrganization2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2.ResourcePoolTax == 75);
        //    Assert.IsTrue(userOrganization2.SalesPriceIncludingResourcePoolTax == 150);
        //    Assert.IsTrue(userOrganization2.TotalIncome == 25);
        //    Assert.IsTrue(userOrganization2.TotalProductionCost == 75);
        //    Assert.IsTrue(userOrganization2.TotalProfit == 0);
        //    Assert.IsTrue(userOrganization2.TotalResourcePoolTax == 75);
        //    Assert.IsTrue(userOrganization2.TotalSalesRevenue == 75);
        //    Assert.IsTrue(userOrganization2.TotalSalesRevenueIncludingResourcePoolTax == 150);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexIncome == 75);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValueMultiplied == 0.375M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValuePercentage == 0.75M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexIncome == 25);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValueMultiplied == 0.125M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValuePercentage == 0.25M);
        //}

        //#endregion

        //#region - Dynamic Organization Index -

        //[TestMethod]
        //public void SingleDynamicOrganizationIndex_SingleUser_TwoOrganizations()
        //{
        //    var resourcePool = new ResourcePool();

        //    var resourcePoolIndex = new ResourcePoolIndex() { ResourcePool = resourcePool, ResourcePoolIndexType = (byte)ResourcePoolIndexType.DynamicOrganizationIndex, RatingSortType = (byte)RatingSortType.HighestToLowest };
        //    resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex);

        //    var organization1 = new Organization() { ResourcePool = resourcePool, ProductionCost = 100, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization1);

        //    var organization2 = new Organization() { ResourcePool = resourcePool, ProductionCost = 100, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization2);

        //    var resourcePoolIndexOrganization1 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization1);
        //    var resourcePoolIndexOrganization2 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization2);

        //    var user = new User();

        //    var userResourcePool = new UserResourcePool() { User = user, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user.UserResourcePoolSet.Add(userResourcePool);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool);

        //    var userResourcePoolIndex = new UserResourcePoolIndex() { UserResourcePool = userResourcePool, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
        //    resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex);

        //    var userOrganization1 = new UserOrganization() { User = user, Organization = organization1, NumberOfSales = 1 };
        //    user.UserOrganizationSet.Add(userOrganization1);
        //    organization1.UserOrganizationSet.Add(userOrganization1);

        //    var userOrganization2 = new UserOrganization() { User = user, Organization = organization2, NumberOfSales = 1 };
        //    user.UserOrganizationSet.Add(userOrganization2);
        //    organization2.UserOrganizationSet.Add(userOrganization2);

        //    var userResourcePoolIndexValue1 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex, Organization = organization1, Rating = 75 };
        //    userResourcePoolIndex.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1);
        //    organization1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1);

        //    var userResourcePoolIndexValue2 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex, Organization = organization2, Rating = 25 };
        //    userResourcePoolIndex.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2);
        //    organization2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2);

        //    var userResourcePoolIndexOrganization1 = new UserResourcePoolIndexOrganization(userOrganization1, resourcePoolIndexOrganization1);
        //    var userResourcePoolIndexOrganization2 = new UserResourcePoolIndexOrganization(userOrganization2, resourcePoolIndexOrganization2);

        //    // Results
        //    Assert.IsTrue(resourcePool.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePool.ProductionCost == 200);
        //    Assert.IsTrue(resourcePool.Profit == 200);
        //    Assert.IsTrue(resourcePool.SalesPrice == 400);

        //    Assert.IsTrue(resourcePoolIndex.IndexRatingCount == 1);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingPercentage == 1);
        //    Assert.IsTrue(resourcePoolIndex.IndexValue == 100);

        //    Assert.IsTrue(organization1.Profit == 100);
        //    Assert.IsTrue(organization2.Profit == 100);

        //    Assert.IsTrue(resourcePoolIndexOrganization1.DynamicOrganizationIndexValueCount == 1);
        //    Assert.IsTrue(resourcePoolIndexOrganization1.DynamicOrganizationIndexValueAverage == 75);
        //    Assert.IsTrue(resourcePoolIndexOrganization1.DynamicOrganizationIndexValuePercentage == 0.75M);

        //    Assert.IsTrue(resourcePoolIndexOrganization2.DynamicOrganizationIndexValueCount == 1);
        //    Assert.IsTrue(resourcePoolIndexOrganization2.DynamicOrganizationIndexValueAverage == 25);
        //    Assert.IsTrue(resourcePoolIndexOrganization2.DynamicOrganizationIndexValuePercentage == 0.25M);

        //    Assert.IsTrue(userResourcePool.NumberOfSales == 2);
        //    Assert.IsTrue(userResourcePool.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool.TotalIncome == 600);
        //    Assert.IsTrue(userResourcePool.TotalProductionCost == 200);
        //    Assert.IsTrue(userResourcePool.TotalProfit == 200);
        //    Assert.IsTrue(userResourcePool.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userResourcePool.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndex.IndexShare == 400);
        //    Assert.IsTrue(userResourcePoolIndex.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization1.IndexIncome == 300);
        //    Assert.IsTrue(userOrganization1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1.TotalIncome == 400);
        //    Assert.IsTrue(userOrganization1.TotalProductionCost == 100);
        //    Assert.IsTrue(userOrganization1.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userOrganization2.IndexIncome == 100);
        //    Assert.IsTrue(userOrganization2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2.TotalIncome == 200);
        //    Assert.IsTrue(userOrganization2.TotalProductionCost == 100);
        //    Assert.IsTrue(userOrganization2.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization2.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization2.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexIncome == 300);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValueMultiplied == 0.375M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValuePercentage == 0.75M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexIncome == 100);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValueMultiplied == 0.125M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValuePercentage == 0.25M);
        //}

        //[TestMethod]
        //public void SingleDynamicOrganizationIndex_TwoUsers_TwoOrganizations()
        //{
        //    var resourcePool = new ResourcePool();

        //    var resourcePoolIndex = new ResourcePoolIndex() { ResourcePool = resourcePool, ResourcePoolIndexType = (byte)ResourcePoolIndexType.DynamicOrganizationIndex, RatingSortType = (byte)RatingSortType.HighestToLowest };
        //    resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex);

        //    var organization1 = new Organization() { ResourcePool = resourcePool, ProductionCost = 100, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization1);

        //    var organization2 = new Organization() { ResourcePool = resourcePool, ProductionCost = 100, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization2);

        //    var resourcePoolIndexOrganization1 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization1);
        //    var resourcePoolIndexOrganization2 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization2);

        //    var user1 = new User();

        //    var userResourcePool1 = new UserResourcePool() { User = user1, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user1.UserResourcePoolSet.Add(userResourcePool1);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool1);

        //    var userResourcePoolIndex1 = new UserResourcePoolIndex() { UserResourcePool = userResourcePool1, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
        //    resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex1);

        //    var userOrganization1_1 = new UserOrganization() { User = user1, Organization = organization1, NumberOfSales = 1 };
        //    user1.UserOrganizationSet.Add(userOrganization1_1);
        //    organization1.UserOrganizationSet.Add(userOrganization1_1);

        //    var userOrganization1_2 = new UserOrganization() { User = user1, Organization = organization2, NumberOfSales = 1 };
        //    user1.UserOrganizationSet.Add(userOrganization1_2);
        //    organization2.UserOrganizationSet.Add(userOrganization1_2);

        //    var userResourcePoolIndexValue1_1 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex1, Organization = organization1, Rating = 80 };
        //    userResourcePoolIndex1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_1);
        //    organization1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_1);

        //    var userResourcePoolIndexValue1_2 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex1, Organization = organization2, Rating = 20 };
        //    userResourcePoolIndex1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_2);
        //    organization2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_2);

        //    var userResourcePoolIndexOrganization1_1 = new UserResourcePoolIndexOrganization(userOrganization1_1, resourcePoolIndexOrganization1);
        //    var userResourcePoolIndexOrganization1_2 = new UserResourcePoolIndexOrganization(userOrganization1_2, resourcePoolIndexOrganization2);

        //    var user2 = new User();

        //    var userResourcePool2 = new UserResourcePool() { User = user2, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user2.UserResourcePoolSet.Add(userResourcePool2);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool2);

        //    var userResourcePoolIndex2 = new UserResourcePoolIndex() { UserResourcePool = userResourcePool2, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
        //    resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex2);

        //    var userOrganization2_1 = new UserOrganization() { User = user2, Organization = organization1, NumberOfSales = 2 };
        //    user2.UserOrganizationSet.Add(userOrganization2_1);
        //    organization1.UserOrganizationSet.Add(userOrganization2_1);

        //    var userOrganization2_2 = new UserOrganization() { User = user2, Organization = organization2, NumberOfSales = 2 };
        //    user2.UserOrganizationSet.Add(userOrganization2_2);
        //    organization2.UserOrganizationSet.Add(userOrganization2_2);

        //    var userResourcePoolIndexValue2_1 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex2, Organization = organization1, Rating = 40 };
        //    userResourcePoolIndex2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_1);
        //    organization1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_1);

        //    var userResourcePoolIndexValue2_2 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex2, Organization = organization2, Rating = 60 };
        //    userResourcePoolIndex2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_2);
        //    organization2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_2);

        //    var userResourcePoolIndexOrganization2_1 = new UserResourcePoolIndexOrganization(userOrganization2_1, resourcePoolIndexOrganization1);
        //    var userResourcePoolIndexOrganization2_2 = new UserResourcePoolIndexOrganization(userOrganization2_2, resourcePoolIndexOrganization2);

        //    // Results
        //    Assert.IsTrue(resourcePool.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePool.ProductionCost == 200);
        //    Assert.IsTrue(resourcePool.Profit == 200);
        //    Assert.IsTrue(resourcePool.SalesPrice == 400);

        //    Assert.IsTrue(resourcePoolIndex.IndexRatingCount == 2);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingPercentage == 1);
        //    Assert.IsTrue(resourcePoolIndex.IndexValue == 100);

        //    Assert.IsTrue(organization1.Profit == 100);
        //    Assert.IsTrue(organization2.Profit == 100);

        //    Assert.IsTrue(resourcePoolIndexOrganization1.DynamicOrganizationIndexValueCount == 2);
        //    Assert.IsTrue(resourcePoolIndexOrganization1.DynamicOrganizationIndexValueAverage == 60);
        //    Assert.IsTrue(resourcePoolIndexOrganization1.DynamicOrganizationIndexValuePercentage == 0.6M);

        //    Assert.IsTrue(resourcePoolIndexOrganization2.DynamicOrganizationIndexValueCount == 2);
        //    Assert.IsTrue(resourcePoolIndexOrganization2.DynamicOrganizationIndexValueAverage == 40);
        //    Assert.IsTrue(resourcePoolIndexOrganization2.DynamicOrganizationIndexValuePercentage == 0.4M);

        //    // User 1
        //    Assert.IsTrue(userResourcePool1.NumberOfSales == 2);
        //    Assert.IsTrue(userResourcePool1.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool1.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool1.TotalIncome == 600);
        //    Assert.IsTrue(userResourcePool1.TotalProductionCost == 200);
        //    Assert.IsTrue(userResourcePool1.TotalProfit == 200);
        //    Assert.IsTrue(userResourcePool1.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool1.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userResourcePool1.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndex1.IndexShare == 400);
        //    Assert.IsTrue(userResourcePoolIndex1.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization1_1.IndexIncome == 240);
        //    Assert.IsTrue(userOrganization1_1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1_1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1_1.TotalIncome == 340);
        //    Assert.IsTrue(userOrganization1_1.TotalProductionCost == 100);
        //    Assert.IsTrue(userOrganization1_1.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1_1.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_1.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1_1.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userOrganization1_2.IndexIncome == 160);
        //    Assert.IsTrue(userOrganization1_2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1_2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1_2.TotalIncome == 260);
        //    Assert.IsTrue(userOrganization1_2.TotalProductionCost == 100);
        //    Assert.IsTrue(userOrganization1_2.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1_2.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_2.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1_2.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1.IndexIncome == 240);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1.IndexValueMultiplied == 0.3M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1.IndexValuePercentage == 0.6M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2.IndexIncome == 160);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2.IndexValueMultiplied == 0.2M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2.IndexValuePercentage == 0.4M);

        //    // User 2
        //    Assert.IsTrue(userResourcePool2.NumberOfSales == 4);
        //    Assert.IsTrue(userResourcePool2.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool2.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool2.TotalIncome == 1200);
        //    Assert.IsTrue(userResourcePool2.TotalProductionCost == 400);
        //    Assert.IsTrue(userResourcePool2.TotalProfit == 400);
        //    Assert.IsTrue(userResourcePool2.TotalResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool2.TotalSalesRevenue == 800);
        //    Assert.IsTrue(userResourcePool2.TotalSalesRevenueIncludingResourcePoolTax == 1600);

        //    Assert.IsTrue(userResourcePoolIndex2.IndexShare == 800);
        //    Assert.IsTrue(userResourcePoolIndex2.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization2_1.IndexIncome == 480);
        //    Assert.IsTrue(userOrganization2_1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2_1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2_1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalIncome == 680);
        //    Assert.IsTrue(userOrganization2_1.TotalProductionCost == 200);
        //    Assert.IsTrue(userOrganization2_1.TotalProfit == 200);
        //    Assert.IsTrue(userOrganization2_1.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userOrganization2_2.IndexIncome == 320);
        //    Assert.IsTrue(userOrganization2_2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2_2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2_2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalIncome == 520);
        //    Assert.IsTrue(userOrganization2_2.TotalProductionCost == 200);
        //    Assert.IsTrue(userOrganization2_2.TotalProfit == 200);
        //    Assert.IsTrue(userOrganization2_2.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1.IndexIncome == 480);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1.IndexValueMultiplied == 0.3M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1.IndexValuePercentage == 0.6M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2.IndexIncome == 320);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2.IndexValueMultiplied == 0.2M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2.IndexValuePercentage == 0.4M);
        //}

        //[TestMethod]
        //public void TwoDynamicOrganizationIndexes_TwoUsers_TwoOrganizations()
        //{
        //    var resourcePool = new ResourcePool();

        //    var resourcePoolIndex1 = new ResourcePoolIndex() { ResourcePool = resourcePool, ResourcePoolIndexType = (byte)ResourcePoolIndexType.DynamicOrganizationIndex, RatingSortType = (byte)RatingSortType.HighestToLowest };
        //    resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex1);

        //    var resourcePoolIndex2 = new ResourcePoolIndex() { ResourcePool = resourcePool, ResourcePoolIndexType = (byte)ResourcePoolIndexType.DynamicOrganizationIndex, RatingSortType = (byte)RatingSortType.HighestToLowest };
        //    resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex2);

        //    var organization1 = new Organization() { ResourcePool = resourcePool, ProductionCost = 100, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization1);

        //    var organization2 = new Organization() { ResourcePool = resourcePool, ProductionCost = 100, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization2);

        //    var resourcePoolIndexOrganization1_1 = new ResourcePoolIndexOrganization(resourcePoolIndex1, organization1);
        //    var resourcePoolIndexOrganization1_2 = new ResourcePoolIndexOrganization(resourcePoolIndex1, organization2);
        //    var resourcePoolIndexOrganization2_1 = new ResourcePoolIndexOrganization(resourcePoolIndex2, organization1);
        //    var resourcePoolIndexOrganization2_2 = new ResourcePoolIndexOrganization(resourcePoolIndex2, organization2);

        //    var user1 = new User();

        //    var userResourcePool1 = new UserResourcePool() { User = user1, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user1.UserResourcePoolSet.Add(userResourcePool1);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool1);

        //    var userResourcePoolIndex1_1 = new UserResourcePoolIndex() { UserResourcePool = userResourcePool1, ResourcePoolIndex = resourcePoolIndex1, Rating = 80 };
        //    resourcePoolIndex1.UserResourcePoolIndexSet.Add(userResourcePoolIndex1_1);

        //    var userResourcePoolIndex2_1 = new UserResourcePoolIndex() { UserResourcePool = userResourcePool1, ResourcePoolIndex = resourcePoolIndex2, Rating = 20 };
        //    resourcePoolIndex2.UserResourcePoolIndexSet.Add(userResourcePoolIndex2_1);

        //    var userOrganization1_1 = new UserOrganization() { User = user1, Organization = organization1, NumberOfSales = 1 };
        //    user1.UserOrganizationSet.Add(userOrganization1_1);
        //    organization1.UserOrganizationSet.Add(userOrganization1_1);

        //    var userOrganization1_2 = new UserOrganization() { User = user1, Organization = organization2, NumberOfSales = 1 };
        //    user1.UserOrganizationSet.Add(userOrganization1_2);
        //    organization2.UserOrganizationSet.Add(userOrganization1_2);

        //    var userResourcePoolIndexValue1_1_1 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex1_1, Organization = organization1, Rating = 80 };
        //    userResourcePoolIndex1_1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_1_1);
        //    organization1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_1_1);

        //    var userResourcePoolIndexValue1_1_2 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex1_1, Organization = organization2, Rating = 20 };
        //    userResourcePoolIndex1_1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_1_2);
        //    organization2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_1_2);

        //    var userResourcePoolIndexOrganization1_1_1 = new UserResourcePoolIndexOrganization(userOrganization1_1, resourcePoolIndexOrganization1_1);
        //    var userResourcePoolIndexOrganization1_1_2 = new UserResourcePoolIndexOrganization(userOrganization1_2, resourcePoolIndexOrganization1_2);

        //    var userResourcePoolIndexValue2_1_1 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex2_1, Organization = organization1, Rating = 80 };
        //    userResourcePoolIndex2_1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_1_1);
        //    organization1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_1_1);

        //    var userResourcePoolIndexValue2_1_2 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex2_1, Organization = organization2, Rating = 20 };
        //    userResourcePoolIndex2_1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_1_2);
        //    organization2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_1_2);

        //    var userResourcePoolIndexOrganization2_1_1 = new UserResourcePoolIndexOrganization(userOrganization1_1, resourcePoolIndexOrganization2_1);
        //    var userResourcePoolIndexOrganization2_1_2 = new UserResourcePoolIndexOrganization(userOrganization1_2, resourcePoolIndexOrganization2_2);

        //    var user2 = new User();

        //    var userResourcePool2 = new UserResourcePool() { User = user2, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user2.UserResourcePoolSet.Add(userResourcePool2);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool2);

        //    var userResourcePoolIndex1_2 = new UserResourcePoolIndex() { UserResourcePool = userResourcePool2, ResourcePoolIndex = resourcePoolIndex1, Rating = 40 };
        //    resourcePoolIndex1.UserResourcePoolIndexSet.Add(userResourcePoolIndex1_2);

        //    var userResourcePoolIndex2_2 = new UserResourcePoolIndex() { UserResourcePool = userResourcePool2, ResourcePoolIndex = resourcePoolIndex2, Rating = 60 };
        //    resourcePoolIndex2.UserResourcePoolIndexSet.Add(userResourcePoolIndex2_2);

        //    var userOrganization2_1 = new UserOrganization() { User = user2, Organization = organization1, NumberOfSales = 2 };
        //    user2.UserOrganizationSet.Add(userOrganization2_1);
        //    organization1.UserOrganizationSet.Add(userOrganization2_1);

        //    var userOrganization2_2 = new UserOrganization() { User = user2, Organization = organization2, NumberOfSales = 2 };
        //    user2.UserOrganizationSet.Add(userOrganization2_2);
        //    organization2.UserOrganizationSet.Add(userOrganization2_2);

        //    var userResourcePoolIndexValue1_2_1 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex1_2, Organization = organization1, Rating = 40 };
        //    userResourcePoolIndex1_2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_2_1);
        //    organization1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_2_1);

        //    var userResourcePoolIndexValue1_2_2 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex1_2, Organization = organization2, Rating = 60 };
        //    userResourcePoolIndex1_2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_2_2);
        //    organization2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue1_2_2);

        //    var userResourcePoolIndexOrganization1_2_1 = new UserResourcePoolIndexOrganization(userOrganization2_1, resourcePoolIndexOrganization1_1);
        //    var userResourcePoolIndexOrganization1_2_2 = new UserResourcePoolIndexOrganization(userOrganization2_2, resourcePoolIndexOrganization1_2);

        //    var userResourcePoolIndexValue2_2_1 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex2_2, Organization = organization1, Rating = 40 };
        //    userResourcePoolIndex2_2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_2_1);
        //    organization1.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_2_1);

        //    var userResourcePoolIndexValue2_2_2 = new UserResourcePoolIndexValue() { UserResourcePoolIndex = userResourcePoolIndex2_2, Organization = organization2, Rating = 60 };
        //    userResourcePoolIndex2_2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_2_2);
        //    organization2.UserResourcePoolIndexValueSet.Add(userResourcePoolIndexValue2_2_2);

        //    var userResourcePoolIndexOrganization2_2_1 = new UserResourcePoolIndexOrganization(userOrganization2_1, resourcePoolIndexOrganization2_1);
        //    var userResourcePoolIndexOrganization2_2_2 = new UserResourcePoolIndexOrganization(userOrganization2_2, resourcePoolIndexOrganization2_2);

        //    // Results
        //    Assert.IsTrue(resourcePool.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePool.ProductionCost == 200);
        //    Assert.IsTrue(resourcePool.Profit == 200);
        //    Assert.IsTrue(resourcePool.SalesPrice == 400);

        //    Assert.IsTrue(resourcePoolIndex1.IndexRatingCount == 2);
        //    Assert.IsTrue(resourcePoolIndex1.IndexRatingAverage == 60);
        //    Assert.IsTrue(resourcePoolIndex1.IndexRatingPercentage == 0.6M);
        //    Assert.IsTrue(resourcePoolIndex1.IndexValue == 100);

        //    Assert.IsTrue(resourcePoolIndex2.IndexRatingCount == 2);
        //    Assert.IsTrue(resourcePoolIndex2.IndexRatingAverage == 40);
        //    Assert.IsTrue(resourcePoolIndex2.IndexRatingPercentage == 0.4M);
        //    Assert.IsTrue(resourcePoolIndex2.IndexValue == 100);

        //    Assert.IsTrue(organization1.Profit == 100);
        //    Assert.IsTrue(organization2.Profit == 100);

        //    Assert.IsTrue(resourcePoolIndexOrganization1_1.DynamicOrganizationIndexValueCount == 2);
        //    Assert.IsTrue(resourcePoolIndexOrganization1_1.DynamicOrganizationIndexValueAverage == 60);
        //    Assert.IsTrue(resourcePoolIndexOrganization1_1.DynamicOrganizationIndexValuePercentage == 0.6M);

        //    Assert.IsTrue(resourcePoolIndexOrganization1_2.DynamicOrganizationIndexValueCount == 2);
        //    Assert.IsTrue(resourcePoolIndexOrganization1_2.DynamicOrganizationIndexValueAverage == 40);
        //    Assert.IsTrue(resourcePoolIndexOrganization1_2.DynamicOrganizationIndexValuePercentage == 0.4M);

        //    Assert.IsTrue(resourcePoolIndexOrganization2_1.DynamicOrganizationIndexValueCount == 2);
        //    Assert.IsTrue(resourcePoolIndexOrganization2_1.DynamicOrganizationIndexValueAverage == 60);
        //    Assert.IsTrue(resourcePoolIndexOrganization2_1.DynamicOrganizationIndexValuePercentage == 0.6M);

        //    Assert.IsTrue(resourcePoolIndexOrganization2_2.DynamicOrganizationIndexValueCount == 2);
        //    Assert.IsTrue(resourcePoolIndexOrganization2_2.DynamicOrganizationIndexValueAverage == 40);
        //    Assert.IsTrue(resourcePoolIndexOrganization2_2.DynamicOrganizationIndexValuePercentage == 0.4M);

        //    // User 1
        //    Assert.IsTrue(userResourcePool1.NumberOfSales == 2);
        //    Assert.IsTrue(userResourcePool1.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool1.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool1.TotalIncome == 600);
        //    Assert.IsTrue(userResourcePool1.TotalProductionCost == 200);
        //    Assert.IsTrue(userResourcePool1.TotalProfit == 200);
        //    Assert.IsTrue(userResourcePool1.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool1.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userResourcePool1.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndex1_1.IndexShare == 240);
        //    Assert.IsTrue(userResourcePoolIndex1_1.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userResourcePoolIndex2_1.IndexShare == 160);
        //    Assert.IsTrue(userResourcePoolIndex2_1.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization1_1.IndexIncome == 240);
        //    Assert.IsTrue(userOrganization1_1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1_1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1_1.TotalIncome == 340);
        //    Assert.IsTrue(userOrganization1_1.TotalProductionCost == 100);
        //    Assert.IsTrue(userOrganization1_1.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1_1.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_1.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1_1.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userOrganization1_2.IndexIncome == 160);
        //    Assert.IsTrue(userOrganization1_2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1_2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1_2.TotalIncome == 260);
        //    Assert.IsTrue(userOrganization1_2.TotalProductionCost == 100);
        //    Assert.IsTrue(userOrganization1_2.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1_2.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_2.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1_2.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1_1.IndexIncome == 144);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1_1.IndexValueMultiplied == 0.3M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1_1.IndexValuePercentage == 0.6M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1_2.IndexIncome == 96);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1_2.IndexValueMultiplied == 0.2M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1_2.IndexValuePercentage == 0.4M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1_1.IndexIncome == 96);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1_1.IndexValueMultiplied == 0.3M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1_1.IndexValuePercentage == 0.6M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1_2.IndexIncome == 64);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1_2.IndexValueMultiplied == 0.2M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1_2.IndexValuePercentage == 0.4M);

        //    // User 2
        //    Assert.IsTrue(userResourcePool2.NumberOfSales == 4);
        //    Assert.IsTrue(userResourcePool2.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool2.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool2.TotalIncome == 1200);
        //    Assert.IsTrue(userResourcePool2.TotalProductionCost == 400);
        //    Assert.IsTrue(userResourcePool2.TotalProfit == 400);
        //    Assert.IsTrue(userResourcePool2.TotalResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool2.TotalSalesRevenue == 800);
        //    Assert.IsTrue(userResourcePool2.TotalSalesRevenueIncludingResourcePoolTax == 1600);

        //    Assert.IsTrue(userResourcePoolIndex1_2.IndexShare == 480);
        //    Assert.IsTrue(userResourcePoolIndex1_2.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userResourcePoolIndex2_2.IndexShare == 320);
        //    Assert.IsTrue(userResourcePoolIndex2_2.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization2_1.IndexIncome == 480);
        //    Assert.IsTrue(userOrganization2_1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2_1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2_1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalIncome == 680);
        //    Assert.IsTrue(userOrganization2_1.TotalProductionCost == 200);
        //    Assert.IsTrue(userOrganization2_1.TotalProfit == 200);
        //    Assert.IsTrue(userOrganization2_1.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userOrganization2_2.IndexIncome == 320);
        //    Assert.IsTrue(userOrganization2_2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2_2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2_2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalIncome == 520);
        //    Assert.IsTrue(userOrganization2_2.TotalProductionCost == 200);
        //    Assert.IsTrue(userOrganization2_2.TotalProfit == 200);
        //    Assert.IsTrue(userOrganization2_2.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2_1.IndexIncome == 288);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2_1.IndexValueMultiplied == 0.3M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2_1.IndexValuePercentage == 0.6M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2_2.IndexIncome == 192);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2_2.IndexValueMultiplied == 0.2M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2_2.IndexValuePercentage == 0.4M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2_1.IndexIncome == 192);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2_1.IndexValueMultiplied == 0.3M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2_1.IndexValuePercentage == 0.6M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2_2.IndexIncome == 128);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2_2.IndexValueMultiplied == 0.2M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2_2.IndexValuePercentage == 0.4M);
        //}

        //#endregion

        //#region - Dynamic Element Index -

        //[TestMethod]
        //public void SingleDynamicElementIndex_SingleUser_TwoOrganizations()
        //{
        //    var resourcePool = new ResourcePool();

        //    var element = new Element() { ResourcePool = resourcePool };
        //    resourcePool.ElementSet.Add(element);

        //    var elementItem1 = new ElementItem() { Element = element };
        //    element.ElementItemSet.Add(elementItem1);

        //    var elementItem2 = new ElementItem() { Element = element };
        //    element.ElementItemSet.Add(elementItem2);

        //    var resourcePoolIndex = new ResourcePoolIndex() { ResourcePool = resourcePool, ResourcePoolIndexType = (byte)ResourcePoolIndexType.DynamicElementIndex, Element = element, RatingSortType = (byte)RatingSortType.HighestToLowest };
        //    resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex);

        //    var organization1 = new Organization() { ResourcePool = resourcePool, ProductionCost = 100, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization1);

        //    var organizationElementItem1 = new OrganizationElementItem() { Organization = organization1, ElementItem = elementItem1 };
        //    organization1.OrganizationElementItemSet.Add(organizationElementItem1);
        //    elementItem1.OrganizationElementItemSet.Add(organizationElementItem1);

        //    var organization2 = new Organization() { ResourcePool = resourcePool, ProductionCost = 100, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization2);

        //    var organizationElementItem2 = new OrganizationElementItem() { Organization = organization2, ElementItem = elementItem2 };
        //    organization2.OrganizationElementItemSet.Add(organizationElementItem2);
        //    elementItem2.OrganizationElementItemSet.Add(organizationElementItem2);

        //    var resourcePoolIndexOrganization1 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization1);
        //    var resourcePoolIndexOrganization2 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization2);

        //    var user = new User();

        //    var userResourcePool = new UserResourcePool() { User = user, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user.UserResourcePoolSet.Add(userResourcePool);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool);

        //    var userResourcePoolIndex = new UserResourcePoolIndex() { UserResourcePool = userResourcePool, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
        //    resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex);

        //    var userOrganization1 = new UserOrganization() { User = user, Organization = organization1, NumberOfSales = 1 };
        //    user.UserOrganizationSet.Add(userOrganization1);
        //    organization1.UserOrganizationSet.Add(userOrganization1);

        //    var userOrganization2 = new UserOrganization() { User = user, Organization = organization2, NumberOfSales = 1 };
        //    user.UserOrganizationSet.Add(userOrganization2);
        //    organization2.UserOrganizationSet.Add(userOrganization2);

        //    var userElementItem1 = new UserElementItem() { User = user, ElementItem = elementItem1, Rating = 75 };
        //    user.UserElementItemSet.Add(userElementItem1);
        //    elementItem1.UserElementItemSet.Add(userElementItem1);

        //    var userElementItem2 = new UserElementItem() { User = user, ElementItem = elementItem2, Rating = 25 };
        //    user.UserElementItemSet.Add(userElementItem2);
        //    elementItem2.UserElementItemSet.Add(userElementItem2);

        //    var userResourcePoolIndexOrganization1 = new UserResourcePoolIndexOrganization(userOrganization1, resourcePoolIndexOrganization1);
        //    var userResourcePoolIndexOrganization2 = new UserResourcePoolIndexOrganization(userOrganization2, resourcePoolIndexOrganization2);

        //    // Results
        //    Assert.IsTrue(resourcePool.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePool.ProductionCost == 200);
        //    Assert.IsTrue(resourcePool.Profit == 200);
        //    Assert.IsTrue(resourcePool.SalesPrice == 400);

        //    Assert.IsTrue(resourcePoolIndex.IndexRatingCount == 1);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingPercentage == 1);

        //    Assert.IsTrue(organization1.Profit == 100);
        //    Assert.IsTrue(organization2.Profit == 100);

        //    Assert.IsTrue(element.RatingAverage == 100);

        //    Assert.IsTrue(elementItem1.RatingCount == 1);
        //    Assert.IsTrue(elementItem1.RatingAverage == 75);
        //    Assert.IsTrue(elementItem1.RatingPercentage == 0.75M);

        //    Assert.IsTrue(elementItem2.RatingCount == 1);
        //    Assert.IsTrue(elementItem2.RatingAverage == 25);
        //    Assert.IsTrue(elementItem2.RatingPercentage == 0.25M);

        //    Assert.IsTrue(userResourcePool.NumberOfSales == 2);
        //    Assert.IsTrue(userResourcePool.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool.TotalIncome == 600);
        //    Assert.IsTrue(userResourcePool.TotalProductionCost == 200);
        //    Assert.IsTrue(userResourcePool.TotalProfit == 200);
        //    Assert.IsTrue(userResourcePool.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userResourcePool.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndex.IndexShare == 400);
        //    Assert.IsTrue(userResourcePoolIndex.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization1.IndexIncome == 300);
        //    Assert.IsTrue(userOrganization1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1.TotalIncome == 400);
        //    Assert.IsTrue(userOrganization1.TotalProductionCost == 100);
        //    Assert.IsTrue(userOrganization1.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userOrganization2.IndexIncome == 100);
        //    Assert.IsTrue(userOrganization2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2.TotalIncome == 200);
        //    Assert.IsTrue(userOrganization2.TotalProductionCost == 100);
        //    Assert.IsTrue(userOrganization2.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization2.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization2.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexIncome == 300);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValueMultiplied == 0.375M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValuePercentage == 0.75M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexIncome == 100);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValueMultiplied == 0.125M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValuePercentage == 0.25M);
        //}

        //[TestMethod]
        //public void SingleDynamicElementIndex_TwoUsers_TwoOrganizations()
        //{
        //    var resourcePool = new ResourcePool();

        //    var element = new Element() { ResourcePool = resourcePool };
        //    resourcePool.ElementSet.Add(element);

        //    var elementItem1 = new ElementItem() { Element = element };
        //    element.ElementItemSet.Add(elementItem1);

        //    var elementItem2 = new ElementItem() { Element = element };
        //    element.ElementItemSet.Add(elementItem2);

        //    var resourcePoolIndex = new ResourcePoolIndex() { ResourcePool = resourcePool, ResourcePoolIndexType = (byte)ResourcePoolIndexType.DynamicElementIndex, Element = element, RatingSortType = (byte)RatingSortType.HighestToLowest };
        //    resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex);

        //    var organization1 = new Organization() { ResourcePool = resourcePool, ProductionCost = 100, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization1);

        //    var organizationElementItem1 = new OrganizationElementItem() { Organization = organization1, ElementItem = elementItem1 };
        //    organization1.OrganizationElementItemSet.Add(organizationElementItem1);
        //    elementItem1.OrganizationElementItemSet.Add(organizationElementItem1);

        //    var organization2 = new Organization() { ResourcePool = resourcePool, ProductionCost = 100, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization2);

        //    var organizationElementItem2 = new OrganizationElementItem() { Organization = organization2, ElementItem = elementItem2 };
        //    organization2.OrganizationElementItemSet.Add(organizationElementItem2);
        //    elementItem2.OrganizationElementItemSet.Add(organizationElementItem2);

        //    var resourcePoolIndexOrganization1 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization1);
        //    var resourcePoolIndexOrganization2 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization2);

        //    var user1 = new User();

        //    var userResourcePool1 = new UserResourcePool() { User = user1, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user1.UserResourcePoolSet.Add(userResourcePool1);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool1);

        //    var userResourcePoolIndex1 = new UserResourcePoolIndex() { UserResourcePool = userResourcePool1, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
        //    resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex1);

        //    var userOrganization1_1 = new UserOrganization() { User = user1, Organization = organization1, NumberOfSales = 1 };
        //    user1.UserOrganizationSet.Add(userOrganization1_1);
        //    organization1.UserOrganizationSet.Add(userOrganization1_1);

        //    var userOrganization1_2 = new UserOrganization() { User = user1, Organization = organization2, NumberOfSales = 1 };
        //    user1.UserOrganizationSet.Add(userOrganization1_2);
        //    organization2.UserOrganizationSet.Add(userOrganization1_2);

        //    var userElementItem1_1 = new UserElementItem() { User = user1, ElementItem = elementItem1, Rating = 80 };
        //    user1.UserElementItemSet.Add(userElementItem1_1);
        //    elementItem1.UserElementItemSet.Add(userElementItem1_1);

        //    var userElementItem1_2 = new UserElementItem() { User = user1, ElementItem = elementItem2, Rating = 20 };
        //    user1.UserElementItemSet.Add(userElementItem1_2);
        //    elementItem2.UserElementItemSet.Add(userElementItem1_2);

        //    var userResourcePoolIndexOrganization1_1 = new UserResourcePoolIndexOrganization(userOrganization1_1, resourcePoolIndexOrganization1);
        //    var userResourcePoolIndexOrganization1_2 = new UserResourcePoolIndexOrganization(userOrganization1_2, resourcePoolIndexOrganization2);

        //    var user2 = new User();

        //    var userResourcePool2 = new UserResourcePool() { User = user2, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user2.UserResourcePoolSet.Add(userResourcePool2);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool2);

        //    var userResourcePoolIndex2 = new UserResourcePoolIndex() { UserResourcePool = userResourcePool2, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
        //    resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex2);

        //    var userOrganization2_1 = new UserOrganization() { User = user2, Organization = organization1, NumberOfSales = 2 };
        //    user2.UserOrganizationSet.Add(userOrganization2_1);
        //    organization1.UserOrganizationSet.Add(userOrganization2_1);

        //    var userOrganization2_2 = new UserOrganization() { User = user2, Organization = organization2, NumberOfSales = 2 };
        //    user2.UserOrganizationSet.Add(userOrganization2_2);
        //    organization2.UserOrganizationSet.Add(userOrganization2_2);

        //    var userElementItem2_1 = new UserElementItem() { User = user2, ElementItem = elementItem1, Rating = 40 };
        //    user1.UserElementItemSet.Add(userElementItem2_1);
        //    elementItem1.UserElementItemSet.Add(userElementItem2_1);

        //    var userElementItem2_2 = new UserElementItem() { User = user2, ElementItem = elementItem2, Rating = 60 };
        //    user1.UserElementItemSet.Add(userElementItem2_2);
        //    elementItem2.UserElementItemSet.Add(userElementItem2_2);

        //    var userResourcePoolIndexOrganization2_1 = new UserResourcePoolIndexOrganization(userOrganization2_1, resourcePoolIndexOrganization1);
        //    var userResourcePoolIndexOrganization2_2 = new UserResourcePoolIndexOrganization(userOrganization2_2, resourcePoolIndexOrganization2);

        //    // Results
        //    Assert.IsTrue(resourcePool.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePool.ProductionCost == 200);
        //    Assert.IsTrue(resourcePool.Profit == 200);
        //    Assert.IsTrue(resourcePool.SalesPrice == 400);

        //    Assert.IsTrue(resourcePoolIndex.IndexRatingCount == 2);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingPercentage == 1);

        //    Assert.IsTrue(organization1.Profit == 100);
        //    Assert.IsTrue(organization2.Profit == 100);

        //    Assert.IsTrue(element.RatingAverage == 100);

        //    Assert.IsTrue(elementItem1.RatingCount == 2);
        //    Assert.IsTrue(elementItem1.RatingAverage == 60);
        //    Assert.IsTrue(elementItem1.RatingPercentage == 0.6M);

        //    Assert.IsTrue(elementItem2.RatingCount == 2);
        //    Assert.IsTrue(elementItem2.RatingAverage == 40);
        //    Assert.IsTrue(elementItem2.RatingPercentage == 0.4M);

        //    // User 1
        //    Assert.IsTrue(userResourcePool1.NumberOfSales == 2);
        //    Assert.IsTrue(userResourcePool1.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool1.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool1.TotalIncome == 600);
        //    Assert.IsTrue(userResourcePool1.TotalProductionCost == 200);
        //    Assert.IsTrue(userResourcePool1.TotalProfit == 200);
        //    Assert.IsTrue(userResourcePool1.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool1.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userResourcePool1.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndex1.IndexShare == 400);
        //    Assert.IsTrue(userResourcePoolIndex1.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization1_1.IndexIncome == 240);
        //    Assert.IsTrue(userOrganization1_1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1_1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1_1.TotalIncome == 340);
        //    Assert.IsTrue(userOrganization1_1.TotalProductionCost == 100);
        //    Assert.IsTrue(userOrganization1_1.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1_1.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_1.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1_1.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userOrganization1_2.IndexIncome == 160);
        //    Assert.IsTrue(userOrganization1_2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1_2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1_2.TotalIncome == 260);
        //    Assert.IsTrue(userOrganization1_2.TotalProductionCost == 100);
        //    Assert.IsTrue(userOrganization1_2.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1_2.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_2.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1_2.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1.IndexIncome == 240);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1.IndexValueMultiplied == 0.3M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1.IndexValuePercentage == 0.6M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2.IndexIncome == 160);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2.IndexValueMultiplied == 0.2M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2.IndexValuePercentage == 0.4M);

        //    // User 2
        //    Assert.IsTrue(userResourcePool2.NumberOfSales == 4);
        //    Assert.IsTrue(userResourcePool2.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool2.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool2.TotalIncome == 1200);
        //    Assert.IsTrue(userResourcePool2.TotalProductionCost == 400);
        //    Assert.IsTrue(userResourcePool2.TotalProfit == 400);
        //    Assert.IsTrue(userResourcePool2.TotalResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool2.TotalSalesRevenue == 800);
        //    Assert.IsTrue(userResourcePool2.TotalSalesRevenueIncludingResourcePoolTax == 1600);

        //    Assert.IsTrue(userResourcePoolIndex2.IndexShare == 800);
        //    Assert.IsTrue(userResourcePoolIndex2.IndexValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization2_1.IndexIncome == 480);
        //    Assert.IsTrue(userOrganization2_1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2_1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2_1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalIncome == 680);
        //    Assert.IsTrue(userOrganization2_1.TotalProductionCost == 200);
        //    Assert.IsTrue(userOrganization2_1.TotalProfit == 200);
        //    Assert.IsTrue(userOrganization2_1.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userOrganization2_2.IndexIncome == 320);
        //    Assert.IsTrue(userOrganization2_2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2_2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2_2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalIncome == 520);
        //    Assert.IsTrue(userOrganization2_2.TotalProductionCost == 200);
        //    Assert.IsTrue(userOrganization2_2.TotalProfit == 200);
        //    Assert.IsTrue(userOrganization2_2.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1.IndexIncome == 480);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1.IndexValueMultiplied == 0.3M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1.IndexValuePercentage == 0.6M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2.IndexIncome == 320);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2.IndexValueMultiplied == 0.2M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2.IndexValuePercentage == 0.4M);
        //}

        //#endregion

        //#region - Dynamic Element Field Index -

        //[TestMethod]
        //public void SingleDynamicElementFieldIndex_SingleUser_TwoOrganizations()
        //{
        //    var resourcePool = new ResourcePool();

        //    var element = new Element() { ResourcePool = resourcePool };
        //    resourcePool.ElementSet.Add(element);

        //    var elementField = new ElementField() { Element = element, ElementFieldType = (byte)ElementFieldType.String };
        //    element.ElementFieldSet.Add(elementField);

        //    var elementItem1 = new ElementItem() { Element = element };
        //    element.ElementItemSet.Add(elementItem1);

        //    var elementCell1 = new ElementCell() { ElementItem = elementItem1, ElementField = elementField };
        //    elementItem1.ElementCellSet.Add(elementCell1);
        //    elementField.ElementCellSet.Add(elementCell1);

        //    var elementItem2 = new ElementItem() { Element = element };
        //    element.ElementItemSet.Add(elementItem2);

        //    var elementCell2 = new ElementCell() { ElementItem = elementItem2, ElementField = elementField };
        //    elementItem2.ElementCellSet.Add(elementCell2);
        //    elementField.ElementCellSet.Add(elementCell2);

        //    var resourcePoolIndex = new ResourcePoolIndex() { ResourcePool = resourcePool, ResourcePoolIndexType = (byte)ResourcePoolIndexType.DynamicElementFieldIndex, ElementField = elementField, RatingSortType = (byte)RatingSortType.HighestToLowest };
        //    resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex);

        //    var organization1 = new Organization() { ResourcePool = resourcePool, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization1);

        //    var organizationElementItem1 = new OrganizationElementItem() { Organization = organization1, ElementItem = elementItem1 };
        //    organization1.OrganizationElementItemSet.Add(organizationElementItem1);
        //    elementItem1.OrganizationElementItemSet.Add(organizationElementItem1);

        //    var organization2 = new Organization() { ResourcePool = resourcePool, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization2);

        //    var organizationElementItem2 = new OrganizationElementItem() { Organization = organization2, ElementItem = elementItem2 };
        //    organization2.OrganizationElementItemSet.Add(organizationElementItem2);
        //    elementItem2.OrganizationElementItemSet.Add(organizationElementItem2);

        //    var resourcePoolIndexOrganization1 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization1);
        //    var resourcePoolIndexOrganization2 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization2);

        //    var user = new User();

        //    var userResourcePool = new UserResourcePool() { User = user, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user.UserResourcePoolSet.Add(userResourcePool);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool);

        //    var userResourcePoolIndex = new UserResourcePoolIndex() { UserResourcePool = userResourcePool, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
        //    resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex);

        //    var userOrganization1 = new UserOrganization() { User = user, Organization = organization1, NumberOfSales = 1 };
        //    user.UserOrganizationSet.Add(userOrganization1);
        //    organization1.UserOrganizationSet.Add(userOrganization1);

        //    var userOrganization2 = new UserOrganization() { User = user, Organization = organization2, NumberOfSales = 1 };
        //    user.UserOrganizationSet.Add(userOrganization2);
        //    organization2.UserOrganizationSet.Add(userOrganization2);

        //    var userElementCell1 = new UserElementCell() { User = user, ElementCell = elementCell1, Rating = 75 };
        //    user.UserElementCellSet.Add(userElementCell1);
        //    elementCell1.UserElementCellSet.Add(userElementCell1);

        //    var userElementCell2 = new UserElementCell() { User = user, ElementCell = elementCell2, Rating = 25 };
        //    user.UserElementCellSet.Add(userElementCell2);
        //    elementCell2.UserElementCellSet.Add(userElementCell2);

        //    var userResourcePoolIndexOrganization1 = new UserResourcePoolIndexOrganization(userOrganization1, resourcePoolIndexOrganization1);
        //    var userResourcePoolIndexOrganization2 = new UserResourcePoolIndexOrganization(userOrganization2, resourcePoolIndexOrganization2);

        //    // Results
        //    Assert.IsTrue(resourcePool.IndexRatingAverage == 100);
        //    //Assert.IsTrue(resourcePool.ProductionCost == 200);
        //    //Assert.IsTrue(resourcePool.Profit == 200);
        //    Assert.IsTrue(resourcePool.SalesPrice == 400);

        //    Assert.IsTrue(resourcePoolIndex.IndexRatingCount == 1);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingPercentage == 1);

        //    //Assert.IsTrue(organization1.Profit == 100);
        //    //Assert.IsTrue(organization2.Profit == 100);

        //    Assert.IsTrue(elementField.RatingAverage == 100);

        //    Assert.IsTrue(elementCell1.RatingCount == 1);
        //    Assert.IsTrue(elementCell1.RatingAverage == 75);
        //    Assert.IsTrue(elementCell1.RatingPercentage == 0.75M);

        //    Assert.IsTrue(elementCell2.RatingCount == 1);
        //    Assert.IsTrue(elementCell2.RatingAverage == 25);
        //    Assert.IsTrue(elementCell2.RatingPercentage == 0.25M);

        //    Assert.IsTrue(userResourcePool.NumberOfSales == 2);
        //    Assert.IsTrue(userResourcePool.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool.TotalIncome == 800);
        //    //Assert.IsTrue(userResourcePool.TotalProductionCost == 200);
        //    //Assert.IsTrue(userResourcePool.TotalProfit == 200);
        //    Assert.IsTrue(userResourcePool.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userResourcePool.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndex.IndexShare == 400);
        //    Assert.IsTrue(userResourcePoolIndex.IndexOrganizationValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization1.IndexIncome == 300);
        //    Assert.IsTrue(userOrganization1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1.TotalIncome == 500);
        //    //Assert.IsTrue(userOrganization1.TotalProductionCost == 100);
        //    //Assert.IsTrue(userOrganization1.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userOrganization2.IndexIncome == 100);
        //    Assert.IsTrue(userOrganization2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2.TotalIncome == 300);
        //    //Assert.IsTrue(userOrganization2.TotalProductionCost == 100);
        //    //Assert.IsTrue(userOrganization2.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization2.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization2.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexIncome == 300);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValueMultiplied == 0.375M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValuePercentage == 0.75M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexIncome == 100);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValueMultiplied == 0.125M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValuePercentage == 0.25M);

        //    // ResourcePoolIndex - Rating Sort Type: Lowest to Highest
        //    resourcePoolIndex.RatingSortType = (byte)RatingSortType.LowestToHighest;

        //    // Results
        //    Assert.IsTrue(userOrganization1.IndexIncome == 100);
        //    Assert.IsTrue(userOrganization1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1.TotalIncome == 300);
        //    //Assert.IsTrue(userOrganization1.TotalProductionCost == 100);
        //    //Assert.IsTrue(userOrganization1.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userOrganization2.IndexIncome == 300);
        //    Assert.IsTrue(userOrganization2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2.TotalIncome == 500);
        //    //Assert.IsTrue(userOrganization2.TotalProductionCost == 100);
        //    //Assert.IsTrue(userOrganization2.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization2.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization2.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexIncome == 100);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValueMultiplied == 0.125M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValuePercentage == 0.25M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexIncome == 300);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValueMultiplied == 0.375M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValuePercentage == 0.75M);
        //}

        //[TestMethod]
        //public void SingleDynamicElementFieldIndex_TwoUsers_TwoOrganizations()
        //{
        //    var resourcePool = new ResourcePool();

        //    var element = new Element() { ResourcePool = resourcePool };
        //    resourcePool.ElementSet.Add(element);

        //    var elementField = new ElementField() { Element = element, ElementFieldType = (byte)ElementFieldType.String };
        //    element.ElementFieldSet.Add(elementField);

        //    var elementItem1 = new ElementItem() { Element = element };
        //    element.ElementItemSet.Add(elementItem1);

        //    var elementCell1 = new ElementCell() { ElementItem = elementItem1, ElementField = elementField };
        //    elementItem1.ElementCellSet.Add(elementCell1);
        //    elementField.ElementCellSet.Add(elementCell1);

        //    var elementItem2 = new ElementItem() { Element = element };
        //    element.ElementItemSet.Add(elementItem2);

        //    var elementCell2 = new ElementCell() { ElementItem = elementItem2, ElementField = elementField };
        //    elementItem2.ElementCellSet.Add(elementCell2);
        //    elementField.ElementCellSet.Add(elementCell2);

        //    var resourcePoolIndex = new ResourcePoolIndex() { ResourcePool = resourcePool, ResourcePoolIndexType = (byte)ResourcePoolIndexType.DynamicElementFieldIndex, ElementField = elementField, RatingSortType = (byte)RatingSortType.HighestToLowest };
        //    resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex);

        //    var organization1 = new Organization() { ResourcePool = resourcePool, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization1);

        //    var organizationElementItem1 = new OrganizationElementItem() { Organization = organization1, ElementItem = elementItem1 };
        //    organization1.OrganizationElementItemSet.Add(organizationElementItem1);
        //    elementItem1.OrganizationElementItemSet.Add(organizationElementItem1);

        //    var organization2 = new Organization() { ResourcePool = resourcePool, SalesPrice = 200 };
        //    resourcePool.OrganizationSet.Add(organization2);

        //    var organizationElementItem2 = new OrganizationElementItem() { Organization = organization2, ElementItem = elementItem2 };
        //    organization2.OrganizationElementItemSet.Add(organizationElementItem2);
        //    elementItem2.OrganizationElementItemSet.Add(organizationElementItem2);

        //    var resourcePoolIndexOrganization1 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization1);
        //    var resourcePoolIndexOrganization2 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization2);

        //    var user1 = new User();

        //    var userResourcePool1 = new UserResourcePool() { User = user1, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user1.UserResourcePoolSet.Add(userResourcePool1);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool1);

        //    var userResourcePoolIndex1 = new UserResourcePoolIndex() { UserResourcePool = userResourcePool1, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
        //    resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex1);

        //    var userOrganization1_1 = new UserOrganization() { User = user1, Organization = organization1, NumberOfSales = 1 };
        //    user1.UserOrganizationSet.Add(userOrganization1_1);
        //    organization1.UserOrganizationSet.Add(userOrganization1_1);

        //    var userOrganization1_2 = new UserOrganization() { User = user1, Organization = organization2, NumberOfSales = 1 };
        //    user1.UserOrganizationSet.Add(userOrganization1_2);
        //    organization2.UserOrganizationSet.Add(userOrganization1_2);

        //    var userElementCell1_1 = new UserElementCell() { User = user1, ElementCell = elementCell1, Rating = 80 };
        //    user1.UserElementCellSet.Add(userElementCell1_1);
        //    elementCell1.UserElementCellSet.Add(userElementCell1_1);

        //    var userElementCell1_2 = new UserElementCell() { User = user1, ElementCell = elementCell2, Rating = 20 };
        //    user1.UserElementCellSet.Add(userElementCell1_2);
        //    elementCell2.UserElementCellSet.Add(userElementCell1_2);

        //    var userResourcePoolIndexOrganization1_1 = new UserResourcePoolIndexOrganization(userOrganization1_1, resourcePoolIndexOrganization1);
        //    var userResourcePoolIndexOrganization1_2 = new UserResourcePoolIndexOrganization(userOrganization1_2, resourcePoolIndexOrganization2);

        //    var user2 = new User();

        //    var userResourcePool2 = new UserResourcePool() { User = user2, ResourcePool = resourcePool, ResourcePoolRate = 100 };
        //    user2.UserResourcePoolSet.Add(userResourcePool2);
        //    resourcePool.UserResourcePoolSet.Add(userResourcePool2);

        //    var userResourcePoolIndex2 = new UserResourcePoolIndex() { UserResourcePool = userResourcePool2, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
        //    resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex2);

        //    var userOrganization2_1 = new UserOrganization() { User = user2, Organization = organization1, NumberOfSales = 2 };
        //    user2.UserOrganizationSet.Add(userOrganization2_1);
        //    organization1.UserOrganizationSet.Add(userOrganization2_1);

        //    var userOrganization2_2 = new UserOrganization() { User = user2, Organization = organization2, NumberOfSales = 2 };
        //    user2.UserOrganizationSet.Add(userOrganization2_2);
        //    organization2.UserOrganizationSet.Add(userOrganization2_2);

        //    var userElementCell2_1 = new UserElementCell() { User = user2, ElementCell = elementCell1, Rating = 40 };
        //    user1.UserElementCellSet.Add(userElementCell2_1);
        //    elementCell1.UserElementCellSet.Add(userElementCell2_1);

        //    var userElementCell2_2 = new UserElementCell() { User = user2, ElementCell = elementCell2, Rating = 60 };
        //    user1.UserElementCellSet.Add(userElementCell2_2);
        //    elementCell2.UserElementCellSet.Add(userElementCell2_2);

        //    var userResourcePoolIndexOrganization2_1 = new UserResourcePoolIndexOrganization(userOrganization2_1, resourcePoolIndexOrganization1);
        //    var userResourcePoolIndexOrganization2_2 = new UserResourcePoolIndexOrganization(userOrganization2_2, resourcePoolIndexOrganization2);

        //    // Results
        //    Assert.IsTrue(resourcePool.IndexRatingAverage == 100);
        //    //Assert.IsTrue(resourcePool.ProductionCost == 200);
        //    //Assert.IsTrue(resourcePool.Profit == 200);
        //    Assert.IsTrue(resourcePool.SalesPrice == 400);

        //    Assert.IsTrue(resourcePoolIndex.IndexRatingCount == 2);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingAverage == 100);
        //    Assert.IsTrue(resourcePoolIndex.IndexRatingPercentage == 1);

        //    //Assert.IsTrue(organization1.Profit == 100);
        //    //Assert.IsTrue(organization2.Profit == 100);

        //    Assert.IsTrue(elementField.RatingAverage == 100);

        //    Assert.IsTrue(elementCell1.RatingCount == 2);
        //    Assert.IsTrue(elementCell1.RatingAverage == 60);
        //    Assert.IsTrue(elementCell1.RatingPercentage == 0.6M);

        //    Assert.IsTrue(elementCell2.RatingCount == 2);
        //    Assert.IsTrue(elementCell2.RatingAverage == 40);
        //    Assert.IsTrue(elementCell2.RatingPercentage == 0.4M);

        //    // User 1
        //    Assert.IsTrue(userResourcePool1.NumberOfSales == 2);
        //    Assert.IsTrue(userResourcePool1.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool1.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool1.TotalIncome == 800);
        //    //Assert.IsTrue(userResourcePool1.TotalProductionCost == 200);
        //    //Assert.IsTrue(userResourcePool1.TotalProfit == 200);
        //    Assert.IsTrue(userResourcePool1.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool1.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userResourcePool1.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndex1.IndexShare == 400);
        //    Assert.IsTrue(userResourcePoolIndex1.IndexOrganizationValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization1_1.IndexIncome == 240);
        //    Assert.IsTrue(userOrganization1_1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1_1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1_1.TotalIncome == 440);
        //    //Assert.IsTrue(userOrganization1_1.TotalProductionCost == 100);
        //    //Assert.IsTrue(userOrganization1_1.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1_1.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_1.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1_1.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userOrganization1_2.IndexIncome == 160);
        //    Assert.IsTrue(userOrganization1_2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization1_2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization1_2.TotalIncome == 360);
        //    //Assert.IsTrue(userOrganization1_2.TotalProductionCost == 100);
        //    //Assert.IsTrue(userOrganization1_2.TotalProfit == 100);
        //    Assert.IsTrue(userOrganization1_2.TotalResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization1_2.TotalSalesRevenue == 200);
        //    Assert.IsTrue(userOrganization1_2.TotalSalesRevenueIncludingResourcePoolTax == 400);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1.IndexIncome == 240);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1.IndexValueMultiplied == 0.3M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_1.IndexValuePercentage == 0.6M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2.IndexIncome == 160);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2.IndexValueMultiplied == 0.2M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization1_2.IndexValuePercentage == 0.4M);

        //    // User 2
        //    Assert.IsTrue(userResourcePool2.NumberOfSales == 4);
        //    Assert.IsTrue(userResourcePool2.ResourcePoolTax == 400);
        //    Assert.IsTrue(userResourcePool2.SalesPriceIncludingResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool2.TotalIncome == 1600);
        //    //Assert.IsTrue(userResourcePool2.TotalProductionCost == 400);
        //    //Assert.IsTrue(userResourcePool2.TotalProfit == 400);
        //    Assert.IsTrue(userResourcePool2.TotalResourcePoolTax == 800);
        //    Assert.IsTrue(userResourcePool2.TotalSalesRevenue == 800);
        //    Assert.IsTrue(userResourcePool2.TotalSalesRevenueIncludingResourcePoolTax == 1600);

        //    Assert.IsTrue(userResourcePoolIndex2.IndexShare == 800);
        //    Assert.IsTrue(userResourcePoolIndex2.IndexOrganizationValueMultiplied == 0.5M);

        //    Assert.IsTrue(userOrganization2_1.IndexIncome == 480);
        //    Assert.IsTrue(userOrganization2_1.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2_1.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2_1.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalIncome == 880);
        //    //Assert.IsTrue(userOrganization2_1.TotalProductionCost == 200);
        //    //Assert.IsTrue(userOrganization2_1.TotalProfit == 200);
        //    Assert.IsTrue(userOrganization2_1.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userOrganization2_1.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userOrganization2_2.IndexIncome == 320);
        //    Assert.IsTrue(userOrganization2_2.NumberOfSalesPercentage == 0.5M);
        //    Assert.IsTrue(userOrganization2_2.ResourcePoolTax == 200);
        //    Assert.IsTrue(userOrganization2_2.SalesPriceIncludingResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalIncome == 720);
        //    //Assert.IsTrue(userOrganization2_2.TotalProductionCost == 200);
        //    //Assert.IsTrue(userOrganization2_2.TotalProfit == 200);
        //    Assert.IsTrue(userOrganization2_2.TotalResourcePoolTax == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalSalesRevenue == 400);
        //    Assert.IsTrue(userOrganization2_2.TotalSalesRevenueIncludingResourcePoolTax == 800);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1.IndexIncome == 480);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1.IndexValueMultiplied == 0.3M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_1.IndexValuePercentage == 0.6M);

        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2.IndexIncome == 320);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2.IndexValueMultiplied == 0.2M);
        //    Assert.IsTrue(userResourcePoolIndexOrganization2_2.IndexValuePercentage == 0.4M);
        //}

        //#endregion

        #region - Dynamic Element Field Index w/o Organization -

        [TestMethod]
        public void TwoElementItems_StringTypeIndex_SingleUser()
        {
            var resourcePool = new ResourcePool();

            var organization = new Element() { ResourcePool = resourcePool, IsMainElement = true };
            resourcePool.ElementSet.Add(organization);

            var organizationName = new ElementField() { Element = organization, Name = "Organization Name", ElementFieldType = (byte)ElementFieldType.String };
            organization.ElementFieldSet.Add(organizationName);

            var salesPrice = new ElementField() { Element = organization, Name = "Sales Price", ElementFieldType = (byte)ElementFieldType.ResourcePool };
            organization.ElementFieldSet.Add(salesPrice);

            var salesNumber = new ElementField() { Element = organization, Name = "Sales Number", ElementFieldType = (byte)ElementFieldType.Multiplier };
            organization.ElementFieldSet.Add(salesNumber);

            var organization1 = new ElementItem() { Element = organization };
            organization.ElementItemSet.Add(organization1);

            var organizationName1 = new ElementCell() { ElementField = organizationName, ElementItem = organization1, StringValue = "Organization 1" };
            organization1.ElementCellSet.Add(organizationName1);
            organizationName.ElementCellSet.Add(organizationName1);

            var organizationSalesPrice1 = new ElementCell() { ElementField = salesPrice, ElementItem = organization1, DecimalValue = 200 };
            organization1.ElementCellSet.Add(organizationSalesPrice1);
            salesPrice.ElementCellSet.Add(organizationSalesPrice1);

            var organizationSalesNumber1 = new ElementCell() { ElementField = salesNumber, ElementItem = organization1, DecimalValue = 1 };
            organization1.ElementCellSet.Add(organizationSalesNumber1);
            salesNumber.ElementCellSet.Add(organizationSalesNumber1);

            var organization2 = new ElementItem() { Element = organization };
            organization.ElementItemSet.Add(organization2);

            var organizationName2 = new ElementCell() { ElementField = organizationName, ElementItem = organization2, StringValue = "Organization 2" };
            organization2.ElementCellSet.Add(organizationName2);
            organizationName.ElementCellSet.Add(organizationName2);

            var organizationSalesPrice2 = new ElementCell() { ElementField = salesPrice, ElementItem = organization2, DecimalValue = 200 };
            organization2.ElementCellSet.Add(organizationSalesPrice2);
            salesPrice.ElementCellSet.Add(organizationSalesPrice2);

            var organizationSalesNumber2 = new ElementCell() { ElementField = salesNumber, ElementItem = organization2, DecimalValue = 1 };
            organization2.ElementCellSet.Add(organizationSalesNumber2);
            salesNumber.ElementCellSet.Add(organizationSalesNumber2);

            var resourcePoolIndex = new ResourcePoolIndex()
            {
                ResourcePool = resourcePool,
                //ResourcePoolIndexType = (byte)ResourcePoolIndexType.DynamicElementFieldIndex,
                ElementField = organizationName,
                RatingSortType = (byte)RatingSortType.HighestToLowest
            };
            resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex);
            organizationName.ResourcePoolIndexSet.Add(resourcePoolIndex);

            //var organization1 = new Organization() { ResourcePool = resourcePool, SalesPrice = 200 };
            //resourcePool.OrganizationSet.Add(organization1);

            //var organizationElementItem1 = new OrganizationElementItem() { Organization = organization1, ElementItem = organization1 };
            //organization1.OrganizationElementItemSet.Add(organizationElementItem1);
            //organization1.OrganizationElementItemSet.Add(organizationElementItem1);

            //var organization2 = new Organization() { ResourcePool = resourcePool, SalesPrice = 200 };
            //resourcePool.OrganizationSet.Add(organization2);

            //var organizationElementItem2 = new OrganizationElementItem() { Organization = organization2, ElementItem = organization2 };
            //organization2.OrganizationElementItemSet.Add(organizationElementItem2);
            //organization2.OrganizationElementItemSet.Add(organizationElementItem2);

            //var resourcePoolIndexOrganization1 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization1);
            //var resourcePoolIndexOrganization2 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization2);

            var user = new User();

            var userResourcePool = new UserResourcePool() { User = user, ResourcePool = resourcePool, ResourcePoolRate = 100 };
            user.UserResourcePoolSet.Add(userResourcePool);
            resourcePool.UserResourcePoolSet.Add(userResourcePool);

            var userResourcePoolIndex = new UserResourcePoolIndex() { UserResourcePool = userResourcePool, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
            resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex);

            var userOrganizationName1 = new UserElementCell() { User = user, ElementCell = organizationName1, Rating = 75 };
            user.UserElementCellSet.Add(userOrganizationName1);
            organizationName1.UserElementCell.Add(userOrganizationName1);

            var userOrganizationName2 = new UserElementCell() { User = user, ElementCell = organizationName2, Rating = 25 };
            user.UserElementCellSet.Add(userOrganizationName1);
            organizationName2.UserElementCell.Add(userOrganizationName2);

            //var userOrganization1 = new UserOrganization() { User = user, Organization = organization1, NumberOfSales = 1 };
            //user.UserOrganizationSet.Add(userOrganization1);
            //organization1.UserOrganizationSet.Add(userOrganization1);

            //var userOrganization2 = new UserOrganization() { User = user, Organization = organization2, NumberOfSales = 1 };
            //user.UserOrganizationSet.Add(userOrganization2);
            //organization2.UserOrganizationSet.Add(userOrganization2);

            //var userElementCell1 = new UserElementCell() { User = user, ElementCell = organizationSalesPrice1, Rating = 75 };
            //user.UserElementCellSet.Add(userElementCell1);
            //organizationSalesPrice1.UserElementCellSet.Add(userElementCell1);

            //var userElementCell2 = new UserElementCell() { User = user, ElementCell = organizationSalesPrice2, Rating = 25 };
            //user.UserElementCellSet.Add(userElementCell2);
            //organizationSalesPrice2.UserElementCellSet.Add(userElementCell2);

            //var userResourcePoolIndexOrganization1 = new UserResourcePoolIndexOrganization(userOrganization1, resourcePoolIndexOrganization1);
            //var userResourcePoolIndexOrganization2 = new UserResourcePoolIndexOrganization(userOrganization2, resourcePoolIndexOrganization2);

            // Results
            Assert.IsTrue(resourcePool.IndexRatingAverage == 100);
            //Assert.IsTrue(resourcePool.ProductionCost == 200);
            //Assert.IsTrue(resourcePool.Profit == 200);
            //Assert.IsTrue(resourcePool.SalesPrice == 400);

            Assert.IsTrue(resourcePoolIndex.IndexRatingCount == 1);
            Assert.IsTrue(resourcePoolIndex.IndexRatingAverage == 100);
            Assert.IsTrue(resourcePoolIndex.IndexRatingPercentage == 1);

            //Assert.IsTrue(organization1.Profit == 100);
            //Assert.IsTrue(organization2.Profit == 100);

            Assert.IsTrue(organizationName.RatingAverage == 100);

            Assert.IsTrue(organizationName1.RatingCount == 1);
            Assert.IsTrue(organizationName1.RatingAverage == 75);
            Assert.IsTrue(organizationName1.RatingPercentage == 0.75M);

            Assert.IsTrue(organizationName2.RatingCount == 1);
            Assert.IsTrue(organizationName2.RatingAverage == 25);
            Assert.IsTrue(organizationName2.RatingPercentage == 0.25M);

            //Assert.IsTrue(userResourcePool.NumberOfSales == 2);
            Assert.IsTrue(resourcePool.ResourcePoolAddition == 400);
            Assert.IsTrue(resourcePool.ResourcePoolFieldItemValueIncludingResourcePoolAddition == 800);
            //Assert.IsTrue(userResourcePool.TotalProductionCost == 200);
            //Assert.IsTrue(userResourcePool.TotalProfit == 200);
            Assert.IsTrue(resourcePool.TotalResourcePoolFieldValue == 400);
            Assert.IsTrue(resourcePool.TotalResourcePoolAddition == 400);
            Assert.IsTrue(resourcePool.TotalResourcePoolFieldItemValueIncludingResourcePoolAddition == 800);
            Assert.IsTrue(resourcePool.TotalIncome == 800);

            Assert.IsTrue(resourcePoolIndex.IndexShare == 400);
            //Assert.IsTrue(userResourcePoolIndex.IndexOrganizationValueMultiplied == 0.5M);

            //Assert.IsTrue(organization1.mul userOrganization1.NumberOfSalesPercentage == 0.5M);
            Assert.IsTrue(organization1.ResourcePoolFieldItemValue == 200);
            Assert.IsTrue(organization1.ResourcePoolAddition == 200);
            Assert.IsTrue(organization1.ResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            //Assert.IsTrue(userOrganization1.TotalProductionCost == 100);
            //Assert.IsTrue(userOrganization1.TotalProfit == 100);
            Assert.IsTrue(organization1.TotalResourcePoolFieldItemValue == 200);
            Assert.IsTrue(organization1.TotalResourcePoolAddition == 200);
            Assert.IsTrue(organization1.TotalResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            Assert.IsTrue(organization1.ResourcePoolIndexIncome == 300);
            Assert.IsTrue(organization1.TotalIncome == 500);

            //Assert.IsTrue(organization2.NumberOfSalesPercentage == 0.5M);
            Assert.IsTrue(organization2.ResourcePoolFieldItemValue == 200);
            Assert.IsTrue(organization2.ResourcePoolAddition == 200);
            Assert.IsTrue(organization2.ResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            //Assert.IsTrue(userOrganization2.TotalProductionCost == 100);
            //Assert.IsTrue(userOrganization2.TotalProfit == 100);
            Assert.IsTrue(organization2.TotalResourcePoolFieldItemValue == 200);
            Assert.IsTrue(organization2.TotalResourcePoolAddition == 200);
            Assert.IsTrue(organization2.TotalResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            Assert.IsTrue(organization2.ResourcePoolIndexIncome == 100);
            Assert.IsTrue(organization2.TotalIncome == 300);

            //Assert.IsTrue(userResourcePoolIndexOrganization1.IndexIncome == 300);
            //Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValueMultiplied == 0.375M);
            //Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValuePercentage == 0.75M);

            //Assert.IsTrue(userResourcePoolIndexOrganization2.IndexIncome == 100);
            //Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValueMultiplied == 0.125M);
            //Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValuePercentage == 0.25M);

            // ResourcePoolIndex - Rating Sort Type: Lowest to Highest
            resourcePoolIndex.RatingSortType = (byte)RatingSortType.LowestToHighest;

            // Results
            //Assert.IsTrue(organization1.NumberOfSalesPercentage == 0.5M);
            Assert.IsTrue(organization1.ResourcePoolFieldItemValue == 200);
            Assert.IsTrue(organization1.ResourcePoolAddition == 200);
            Assert.IsTrue(organization1.ResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            //Assert.IsTrue(userOrganization1.TotalProductionCost == 100);
            //Assert.IsTrue(userOrganization1.TotalProfit == 100);
            Assert.IsTrue(organization1.TotalResourcePoolFieldItemValue == 200);
            Assert.IsTrue(organization1.TotalResourcePoolAddition == 200);
            Assert.IsTrue(organization1.TotalResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            Assert.IsTrue(organization1.ResourcePoolIndexIncome == 100);
            Assert.IsTrue(organization1.TotalIncome == 300);

            //Assert.IsTrue(organization2.mul userOrganization2.NumberOfSalesPercentage == 0.5M);
            Assert.IsTrue(organization2.ResourcePoolFieldItemValue == 200);
            Assert.IsTrue(organization2.ResourcePoolAddition == 200);
            Assert.IsTrue(organization2.ResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            //Assert.IsTrue(userOrganization2.TotalProductionCost == 100);
            //Assert.IsTrue(userOrganization2.TotalProfit == 100);
            Assert.IsTrue(organization2.TotalResourcePoolFieldItemValue == 200);
            Assert.IsTrue(organization2.TotalResourcePoolAddition == 200);
            Assert.IsTrue(organization2.TotalResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            Assert.IsTrue(organization2.ResourcePoolIndexIncome == 300);
            Assert.IsTrue(organization2.TotalIncome == 500);

            //Assert.IsTrue(userOrganization1.IndexIncome == 100);
            //Assert.IsTrue(userOrganization1.NumberOfSalesPercentage == 0.5M);
            //Assert.IsTrue(userOrganization1.ResourcePoolTax == 200);
            //Assert.IsTrue(userOrganization1.SalesPriceIncludingResourcePoolTax == 400);
            //Assert.IsTrue(userOrganization1.TotalIncome == 300);
            ////Assert.IsTrue(userOrganization1.TotalProductionCost == 100);
            ////Assert.IsTrue(userOrganization1.TotalProfit == 100);
            //Assert.IsTrue(userOrganization1.TotalResourcePoolTax == 200);
            //Assert.IsTrue(userOrganization1.TotalSalesRevenue == 200);
            //Assert.IsTrue(userOrganization1.TotalSalesRevenueIncludingResourcePoolTax == 400);

            //Assert.IsTrue(userOrganization2.IndexIncome == 300);
            //Assert.IsTrue(userOrganization2.NumberOfSalesPercentage == 0.5M);
            //Assert.IsTrue(userOrganization2.ResourcePoolTax == 200);
            //Assert.IsTrue(userOrganization2.SalesPriceIncludingResourcePoolTax == 400);
            //Assert.IsTrue(userOrganization2.TotalIncome == 500);
            ////Assert.IsTrue(userOrganization2.TotalProductionCost == 100);
            ////Assert.IsTrue(userOrganization2.TotalProfit == 100);
            //Assert.IsTrue(userOrganization2.TotalResourcePoolTax == 200);
            //Assert.IsTrue(userOrganization2.TotalSalesRevenue == 200);
            //Assert.IsTrue(userOrganization2.TotalSalesRevenueIncludingResourcePoolTax == 400);

            //Assert.IsTrue(userResourcePoolIndexOrganization1.IndexIncome == 100);
            //Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValueMultiplied == 0.125M);
            //Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValuePercentage == 0.25M);

            //Assert.IsTrue(userResourcePoolIndexOrganization2.IndexIncome == 300);
            //Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValueMultiplied == 0.375M);
            //Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValuePercentage == 0.75M);
        }

        [TestMethod]
        public void TwoElementItems_DecimalTypeIndex_SingleUser()
        {
            var resourcePool = new ResourcePool();

            var organization = new Element() { ResourcePool = resourcePool, IsMainElement = true };
            resourcePool.ElementSet.Add(organization);

            var salesPrice = new ElementField() { Element = organization, Name = "Sales Price", ElementFieldType = (byte)ElementFieldType.ResourcePool };
            organization.ElementFieldSet.Add(salesPrice);

            var salesNumber = new ElementField() { Element = organization, Name = "Sales Number", ElementFieldType = (byte)ElementFieldType.Multiplier };
            organization.ElementFieldSet.Add(salesNumber);

            var organization1 = new ElementItem() { Element = organization };
            organization.ElementItemSet.Add(organization1);

            var organizationSalesPrice1 = new ElementCell() { ElementField = salesPrice, ElementItem = organization1, DecimalValue = 25 };
            organization1.ElementCellSet.Add(organizationSalesPrice1);
            salesPrice.ElementCellSet.Add(organizationSalesPrice1);

            var organizationSalesNumber1 = new ElementCell() { ElementField = salesNumber, ElementItem = organization1, DecimalValue = 1 };
            organization1.ElementCellSet.Add(organizationSalesNumber1);
            salesNumber.ElementCellSet.Add(organizationSalesNumber1);

            var organization2 = new ElementItem() { Element = organization };
            organization.ElementItemSet.Add(organization2);

            var organizationSalesPrice2 = new ElementCell() { ElementField = salesPrice, ElementItem = organization2, DecimalValue = 75 };
            organization2.ElementCellSet.Add(organizationSalesPrice2);
            salesPrice.ElementCellSet.Add(organizationSalesPrice2);

            var organizationSalesNumber2 = new ElementCell() { ElementField = salesNumber, ElementItem = organization2, DecimalValue = 1 };
            organization2.ElementCellSet.Add(organizationSalesNumber2);
            salesNumber.ElementCellSet.Add(organizationSalesNumber2);

            var resourcePoolIndex = new ResourcePoolIndex()
            {
                ResourcePool = resourcePool,
                //ResourcePoolIndexType = (byte)ResourcePoolIndexType.DynamicElementFieldIndex,
                ElementField = salesPrice,
                RatingSortType = (byte)RatingSortType.LowestToHighest
            };
            resourcePool.ResourcePoolIndexSet.Add(resourcePoolIndex);
            salesPrice.ResourcePoolIndexSet.Add(resourcePoolIndex);

            //var organization1 = new Organization() { ResourcePool = resourcePool, SalesPrice = 200 };
            //resourcePool.OrganizationSet.Add(organization1);

            //var organizationElementItem1 = new OrganizationElementItem() { Organization = organization1, ElementItem = organization1 };
            //organization1.OrganizationElementItemSet.Add(organizationElementItem1);
            //organization1.OrganizationElementItemSet.Add(organizationElementItem1);

            //var organization2 = new Organization() { ResourcePool = resourcePool, SalesPrice = 200 };
            //resourcePool.OrganizationSet.Add(organization2);

            //var organizationElementItem2 = new OrganizationElementItem() { Organization = organization2, ElementItem = organization2 };
            //organization2.OrganizationElementItemSet.Add(organizationElementItem2);
            //organization2.OrganizationElementItemSet.Add(organizationElementItem2);

            //var resourcePoolIndexOrganization1 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization1);
            //var resourcePoolIndexOrganization2 = new ResourcePoolIndexOrganization(resourcePoolIndex, organization2);

            var user = new User();

            var userResourcePool = new UserResourcePool() { User = user, ResourcePool = resourcePool, ResourcePoolRate = 100 };
            user.UserResourcePoolSet.Add(userResourcePool);
            resourcePool.UserResourcePoolSet.Add(userResourcePool);

            var userResourcePoolIndex = new UserResourcePoolIndex() { UserResourcePool = userResourcePool, ResourcePoolIndex = resourcePoolIndex, Rating = 100 };
            resourcePoolIndex.UserResourcePoolIndexSet.Add(userResourcePoolIndex);

            //var userOrganization1 = new UserOrganization() { User = user, Organization = organization1, NumberOfSales = 1 };
            //user.UserOrganizationSet.Add(userOrganization1);
            //organization1.UserOrganizationSet.Add(userOrganization1);

            //var userOrganization2 = new UserOrganization() { User = user, Organization = organization2, NumberOfSales = 1 };
            //user.UserOrganizationSet.Add(userOrganization2);
            //organization2.UserOrganizationSet.Add(userOrganization2);

            //var userElementCell1 = new UserElementCell() { User = user, ElementCell = organizationSalesPrice1, Rating = 75 };
            //user.UserElementCellSet.Add(userElementCell1);
            //organizationSalesPrice1.UserElementCellSet.Add(userElementCell1);

            //var userElementCell2 = new UserElementCell() { User = user, ElementCell = organizationSalesPrice2, Rating = 25 };
            //user.UserElementCellSet.Add(userElementCell2);
            //organizationSalesPrice2.UserElementCellSet.Add(userElementCell2);

            //var userResourcePoolIndexOrganization1 = new UserResourcePoolIndexOrganization(userOrganization1, resourcePoolIndexOrganization1);
            //var userResourcePoolIndexOrganization2 = new UserResourcePoolIndexOrganization(userOrganization2, resourcePoolIndexOrganization2);

            // Results
            Assert.IsTrue(resourcePool.IndexRatingAverage == 100);
            //Assert.IsTrue(resourcePool.ProductionCost == 200);
            //Assert.IsTrue(resourcePool.Profit == 200);
            //Assert.IsTrue(resourcePool.SalesPrice == 400);

            Assert.IsTrue(resourcePoolIndex.IndexRatingCount == 1);
            Assert.IsTrue(resourcePoolIndex.IndexRatingAverage == 100);
            Assert.IsTrue(resourcePoolIndex.IndexRatingPercentage == 1);

            //Assert.IsTrue(organization1.Profit == 100);
            //Assert.IsTrue(organization2.Profit == 100);

            Assert.IsTrue(salesPrice.RatingAverage == 100);

            //Assert.IsTrue(userResourcePool.NumberOfSales == 2);
            Assert.IsTrue(resourcePool.ResourcePoolAddition == 100);
            Assert.IsTrue(resourcePool.ResourcePoolFieldItemValueIncludingResourcePoolAddition == 200);
            //Assert.IsTrue(userResourcePool.TotalProductionCost == 200);
            //Assert.IsTrue(userResourcePool.TotalProfit == 200);
            Assert.IsTrue(resourcePool.TotalResourcePoolFieldValue == 100);
            Assert.IsTrue(resourcePool.TotalResourcePoolAddition == 100);
            Assert.IsTrue(resourcePool.TotalResourcePoolFieldItemValueIncludingResourcePoolAddition == 200);
            Assert.IsTrue(resourcePool.TotalIncome == 200);

            Assert.IsTrue(resourcePoolIndex.IndexShare == 100);
            //Assert.IsTrue(userResourcePoolIndex.IndexOrganizationValueMultiplied == 0.5M);

            //Assert.IsTrue(organization1.mul userOrganization1.NumberOfSalesPercentage == 0.5M);
            Assert.IsTrue(organization1.ResourcePoolFieldItemValue == 25);
            Assert.IsTrue(organization1.ResourcePoolAddition == 25);
            Assert.IsTrue(organization1.ResourcePoolFieldItemValueIncludingResourcePoolAddition == 50);
            //Assert.IsTrue(userOrganization1.TotalProductionCost == 100);
            //Assert.IsTrue(userOrganization1.TotalProfit == 100);
            Assert.IsTrue(organization1.TotalResourcePoolFieldItemValue == 25);
            Assert.IsTrue(organization1.TotalResourcePoolAddition == 25);
            Assert.IsTrue(organization1.TotalResourcePoolFieldItemValueIncludingResourcePoolAddition == 50);
            Assert.IsTrue(organization1.ResourcePoolIndexIncome == 75);
            Assert.IsTrue(organization1.TotalIncome == 100);

            //Assert.IsTrue(organization2.NumberOfSalesPercentage == 0.5M);
            Assert.IsTrue(organization2.ResourcePoolFieldItemValue == 75);
            Assert.IsTrue(organization2.ResourcePoolAddition == 75);
            Assert.IsTrue(organization2.ResourcePoolFieldItemValueIncludingResourcePoolAddition == 150);
            //Assert.IsTrue(userOrganization2.TotalProductionCost == 100);
            //Assert.IsTrue(userOrganization2.TotalProfit == 100);
            Assert.IsTrue(organization2.TotalResourcePoolFieldItemValue == 75);
            Assert.IsTrue(organization2.TotalResourcePoolAddition == 75);
            Assert.IsTrue(organization2.TotalResourcePoolFieldItemValueIncludingResourcePoolAddition == 150);
            Assert.IsTrue(organization2.ResourcePoolIndexIncome == 25);
            Assert.IsTrue(organization2.TotalIncome == 100);

            //Assert.IsTrue(userResourcePoolIndexOrganization1.IndexIncome == 300);
            //Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValueMultiplied == 0.375M);
            //Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValuePercentage == 0.75M);

            //Assert.IsTrue(userResourcePoolIndexOrganization2.IndexIncome == 100);
            //Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValueMultiplied == 0.125M);
            //Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValuePercentage == 0.25M);

            //// ResourcePoolIndex - Rating Sort Type: Lowest to Highest
            //resourcePoolIndex.RatingSortType = (byte)RatingSortType.LowestToHighest;

            //// Results
            ////Assert.IsTrue(organization1.NumberOfSalesPercentage == 0.5M);
            //Assert.IsTrue(organization1.ResourcePoolFieldItemValue == 25);
            //Assert.IsTrue(organization1.ResourcePoolAddition == 200);
            //Assert.IsTrue(organization1.ResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            ////Assert.IsTrue(userOrganization1.TotalProductionCost == 100);
            ////Assert.IsTrue(userOrganization1.TotalProfit == 100);
            //Assert.IsTrue(organization1.TotalResourcePoolFieldItemValue == 200);
            //Assert.IsTrue(organization1.TotalResourcePoolAddition == 200);
            //Assert.IsTrue(organization1.TotalResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            //Assert.IsTrue(organization1.ResourcePoolIndexIncome == 100);
            //Assert.IsTrue(organization1.TotalIncome == 300);

            ////Assert.IsTrue(organization2.mul userOrganization2.NumberOfSalesPercentage == 0.5M);
            //Assert.IsTrue(organization2.ResourcePoolFieldItemValue == 25);
            //Assert.IsTrue(organization2.ResourcePoolAddition == 200);
            //Assert.IsTrue(organization2.ResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            ////Assert.IsTrue(userOrganization2.TotalProductionCost == 100);
            ////Assert.IsTrue(userOrganization2.TotalProfit == 100);
            //Assert.IsTrue(organization2.TotalResourcePoolFieldItemValue == 200);
            //Assert.IsTrue(organization2.TotalResourcePoolAddition == 200);
            //Assert.IsTrue(organization2.TotalResourcePoolFieldItemValueIncludingResourcePoolAddition == 400);
            //Assert.IsTrue(organization2.ResourcePoolIndexIncome == 300);
            //Assert.IsTrue(organization2.TotalIncome == 500);

            ////Assert.IsTrue(userOrganization1.IndexIncome == 100);
            ////Assert.IsTrue(userOrganization1.NumberOfSalesPercentage == 0.5M);
            ////Assert.IsTrue(userOrganization1.ResourcePoolTax == 200);
            ////Assert.IsTrue(userOrganization1.SalesPriceIncludingResourcePoolTax == 400);
            ////Assert.IsTrue(userOrganization1.TotalIncome == 300);
            //////Assert.IsTrue(userOrganization1.TotalProductionCost == 100);
            //////Assert.IsTrue(userOrganization1.TotalProfit == 100);
            ////Assert.IsTrue(userOrganization1.TotalResourcePoolTax == 200);
            ////Assert.IsTrue(userOrganization1.TotalSalesRevenue == 200);
            ////Assert.IsTrue(userOrganization1.TotalSalesRevenueIncludingResourcePoolTax == 400);

            ////Assert.IsTrue(userOrganization2.IndexIncome == 300);
            ////Assert.IsTrue(userOrganization2.NumberOfSalesPercentage == 0.5M);
            ////Assert.IsTrue(userOrganization2.ResourcePoolTax == 200);
            ////Assert.IsTrue(userOrganization2.SalesPriceIncludingResourcePoolTax == 400);
            ////Assert.IsTrue(userOrganization2.TotalIncome == 500);
            //////Assert.IsTrue(userOrganization2.TotalProductionCost == 100);
            //////Assert.IsTrue(userOrganization2.TotalProfit == 100);
            ////Assert.IsTrue(userOrganization2.TotalResourcePoolTax == 200);
            ////Assert.IsTrue(userOrganization2.TotalSalesRevenue == 200);
            ////Assert.IsTrue(userOrganization2.TotalSalesRevenueIncludingResourcePoolTax == 400);

            ////Assert.IsTrue(userResourcePoolIndexOrganization1.IndexIncome == 100);
            ////Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValueMultiplied == 0.125M);
            ////Assert.IsTrue(userResourcePoolIndexOrganization1.IndexValuePercentage == 0.25M);

            ////Assert.IsTrue(userResourcePoolIndexOrganization2.IndexIncome == 300);
            ////Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValueMultiplied == 0.375M);
            ////Assert.IsTrue(userResourcePoolIndexOrganization2.IndexValuePercentage == 0.75M);
        }

        // TODO !
        //[TestMethod]
        // public void TwoElementItems_SingleIndex_TwoUsers()

        #endregion

    }
}
