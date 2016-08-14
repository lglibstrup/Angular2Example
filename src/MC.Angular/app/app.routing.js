"use strict";
var router_1 = require('@angular/router');
var dashboard_component_1 = require('./components/dashboard.component');
var network_detail_component_1 = require('./components/network-detail.component');
var test_component_1 = require('./components/test.component');
var appRoutes = [
    {
        path: '',
        redirectTo: '/dashboard',
        pathMatch: 'full'
    },
    {
        path: 'dashboard',
        component: dashboard_component_1.DashboardComponent
    },
    {
        path: 'tests',
        component: test_component_1.TestComponent
    },
    {
        path: 'network',
        component: network_detail_component_1.NetworkDetailComponent
    },
    {
        path: 'network/:id',
        component: network_detail_component_1.NetworkDetailComponent
    }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map