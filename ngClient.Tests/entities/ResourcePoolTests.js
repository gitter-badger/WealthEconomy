﻿/// <reference path="Commons.js" />

describe('ng ResourcePool', function () {

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

    it('displayRatingMode - default', function () {

        var resourcePool1 = new ResourcePool();

        expect(resourcePool1.displayRatingMode()).toBe(true);

    });

    it('displayRatingMode - use fixed cmrp rate', function () {

        var resourcePool1 = new ResourcePool();

        // true vs. false
        resourcePool1.UseFixedResourcePoolRate = true;
        expect(resourcePool1.displayRatingMode()).toBe(false);

        // false vs. true
        resourcePool1.UseFixedResourcePoolRate = false;
        expect(resourcePool1.displayRatingMode()).toBe(true);
    
    });

    it('displayRatingMode - single field index', function () {

        var resourcePool = new ResourcePool();

        var element1 = new Element();
        element1.ResourcePool = resourcePool;
        resourcePool.ElementSet = [element1];
        element1.IsMainElement = true;
        // Since default is already 'true', To be sure that adding a field index makes it 'true'
        resourcePool.UseFixedResourcePoolRate = true;

        var field1 = new ElementField();
        field1.Element = element1;
        field1.DataType = 4;
        field1.IndexEnabled = true;
        element1.ElementFieldSet = [field1];

        // false vs. true
        field1.UseFixedValue = false;
        expect(resourcePool.displayRatingMode()).toBe(true);

        // true vs. false
        field1.UseFixedValue = true;
        expect(resourcePool.displayRatingMode()).toBe(false);

        // TODO Remove case

    });

    it('displayRatingMode - multiple indexes', function () {

        var resourcePool = new ResourcePool();

        var element1 = new Element();
        element1.ResourcePool = resourcePool;
        element1.IsMainElement = true;
        resourcePool.ElementSet = [element1];
        // Since default is already 'true', To be sure that adding a field index makes it 'true'
        resourcePool.UseFixedResourcePoolRate = true;

        var field1 = new ElementField();
        field1.Element = element1;
        field1.DataType = 4;
        field1.IndexEnabled = true;
        element1.ElementFieldSet = [field1];

        var field2 = new ElementField();
        field2.Element = element1;
        field2.DataType = 4;
        field2.IndexEnabled = true;
        element1.ElementFieldSet = [field2];

        expect(resourcePool.displayRatingMode()).toBe(true);

        // TODO Remove case

    });

    it('toggleRatingMode', function () {

        var resourcePool1 = new ResourcePool();

        // Default
        expect(resourcePool1.RatingMode).toBe(1);

        // First toggle
        resourcePool1.toggleRatingMode();
        expect(resourcePool1.RatingMode).toBe(2);

        // Second toggle
        resourcePool1.toggleRatingMode();
        expect(resourcePool1.RatingMode).toBe(1);

    });

    it('userResourcePool', function () {

        var resourcePool1 = new ResourcePool();

        expect(resourcePool1.currentUserResourcePool()).toBe(null);

        var userResourcePool1 = new UserResourcePool();
        userResourcePool1.ResourcePool = resourcePool1;
        resourcePool1.UserResourcePoolSet = [userResourcePool1];

        expect(resourcePool1.currentUserResourcePool()).not.toBe(null);

    });

    it('currentUserResourcePoolRate', function () {

        var resourcePool1 = new ResourcePool();

        // Case 1: Default value
        expect(resourcePool1.currentUserResourcePoolRate()).toBe(10);

        // Case 2: Add new userResourcePool
        resourcePool1.UseFixedResourcePoolRate = false;

        var userResourcePool1 = new UserResourcePool();
        userResourcePool1.ResourcePool = resourcePool1;
        userResourcePool1.ResourcePoolRate = 20;
        resourcePool1.UserResourcePoolSet = [userResourcePool1];

        // TODO Manually update?!
        resourcePool1.setCurrentUserResourcePoolRate();

        expect(resourcePool1.currentUserResourcePoolRate()).toBe(20);

        // TODO Case 3: Remove userResourcePool

    });

    it('otherUsersResourcePoolRateTotal', function () {

        var resourcePool1 = new ResourcePool();

        // Default value
        expect(resourcePool1.otherUsersResourcePoolRateTotal()).toBe(0);

        // Without userResourcePool
        resourcePool1.ResourcePoolRateTotal = 30;

        // TODO Manually update?!
        resourcePool1.setOtherUsersResourcePoolRateTotal();

        expect(resourcePool1.otherUsersResourcePoolRateTotal()).toBe(30);

        // With userResourcePool
        var userResourcePool1 = new UserResourcePool();
        userResourcePool1.ResourcePool = resourcePool1;
        userResourcePool1.ResourcePoolRate = 10;
        resourcePool1.UserResourcePoolSet = [userResourcePool1];

        // TODO Manually update?!
        resourcePool1.setOtherUsersResourcePoolRateTotal();

        expect(resourcePool1.otherUsersResourcePoolRateTotal()).toBe(20);

    });

    it('otherUsersResourcePoolRateCount', function () {

        var resourcePool1 = new ResourcePool();

        // Default value
        expect(resourcePool1.otherUsersResourcePoolRateCount()).toBe(0);

        // Without userResourcePool
        resourcePool1.ResourcePoolRateCount = 2;

        // TODO Manually update?!
        resourcePool1.setOtherUsersResourcePoolRateCount();

        expect(resourcePool1.otherUsersResourcePoolRateCount()).toBe(2);

        // With userResourcePool
        var userResourcePool1 = new UserResourcePool();
        userResourcePool1.ResourcePool = resourcePool1;
        userResourcePool1.ResourcePoolRate = 10;
        resourcePool1.UserResourcePoolSet = [userResourcePool1];

        // TODO Manually update?!
        resourcePool1.setOtherUsersResourcePoolRateCount();

        expect(resourcePool1.otherUsersResourcePoolRateCount()).toBe(1);

    });

    it('resourcePoolRateTotal', function () {

        var resourcePool1 = new ResourcePool();

        // Case 1: Initial value
        expect(resourcePool1.resourcePoolRateTotal()).toBe(10);

        // Case 2: Use fixed cmrp rate true; the value should come from the server (ResourcePoolRateTotal)
        // but it's not defined yet, so total is 0
        resourcePool1.UseFixedResourcePoolRate = true;

        expect(resourcePool1.resourcePoolRateTotal()).toBe(0);

        // Case 3: Define server-side variables
        resourcePool1.ResourcePoolRateTotal = 30;

        // TODO Manually update?!
        resourcePool1.setOtherUsersResourcePoolRateTotal();

        expect(resourcePool1.resourcePoolRateTotal()).toBe(30);

        // Case 4: Use fixed cmrp rate false; means the current user also will have a value
        resourcePool1.UseFixedResourcePoolRate = false;

        expect(resourcePool1.resourcePoolRateTotal()).toBe(40);

    });

    it('resourcePoolRateCount', function () {

        var resourcePool1 = new ResourcePool();

        // Case 1: Initial value
        expect(resourcePool1.resourcePoolRateCount()).toBe(1);

        // Case 2: Use fixed cmrp rate true; the value should come from the server (ResourcePoolRateCount)
        // but it's not defined yet, so count is 0
        resourcePool1.UseFixedResourcePoolRate = true;

        expect(resourcePool1.resourcePoolRateCount()).toBe(0);

        // Case 3: Define server-side variables
        resourcePool1.ResourcePoolRateTotal = 30;
        resourcePool1.ResourcePoolRateCount = 2;

        // TODO Manually update?!
        resourcePool1.setOtherUsersResourcePoolRateCount();

        expect(resourcePool1.resourcePoolRateCount()).toBe(2);

        // Case 4: Use fixed cmrp rate false; means the current user also will have a value
        resourcePool1.UseFixedResourcePoolRate = false;

        expect(resourcePool1.resourcePoolRateCount()).toBe(3);

    });

    it('resourcePoolRateAverage', function () {

        var resourcePool1 = new ResourcePool();

        // Case 1: Initial value
        expect(resourcePool1.resourcePoolRateAverage()).toBe(10);

        // Case 2: With server-side variables
        resourcePool1.ResourcePoolRateTotal = 20;
        resourcePool1.ResourcePoolRateCount = 1;

        // TODO Manually update?!
        resourcePool1.setOtherUsersResourcePoolRateTotal();
        resourcePool1.setOtherUsersResourcePoolRateCount();

        expect(resourcePool1.resourcePoolRateAverage()).toBe(15);

    });

    it('resourcePoolRate', function () {

        var resourcePool1 = new ResourcePool();

        // Case 1: Initial values
        // a. UseFixedResourcePoolRate: false
        // b. RatingMode: 1
        // c. No server variables
        // expect currentUsers' default value: 10
        expect(resourcePool1.resourcePoolRate()).toBe(10);

        // Case 1: UseFixedResourcePoolRate
        // a. UseFixedResourcePoolRate: true
        // b. RatingMode: 1
        // c. No server variables
        // expect 0, since there are no server variables yet
        resourcePool1.UseFixedResourcePoolRate = true;

        expect(resourcePool1.resourcePoolRate()).toBe(0);

        // Case 3: RatingMode
        // a. UseFixedResourcePoolRate: false
        // b. RatingMode: 2
        // c. With server variables
        // expect 20 + 10 (current user's default) / 2
        resourcePool1.ResourcePoolRateTotal = 20;
        resourcePool1.ResourcePoolRateCount = 1;

        // TODO Manually update?!
        resourcePool1.setOtherUsersResourcePoolRateTotal();
        resourcePool1.setOtherUsersResourcePoolRateCount();
        resourcePool1.toggleRatingMode();
        resourcePool1.UseFixedResourcePoolRate = false;

        expect(resourcePool1.resourcePoolRate()).toBe(15);

    });

    it('resourcePoolRatePercentage', function () {

        var resourcePool1 = new ResourcePool();

        expect(resourcePool1.resourcePoolRatePercentage()).toBe(0.1);

    });

});
