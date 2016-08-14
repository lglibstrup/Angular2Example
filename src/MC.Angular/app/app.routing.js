"use strict";
var router_1 = require('@angular/router');
var dashboard_component_1 = require('./components/dashboard.component');
var heroes_component_1 = require('./components/heroes.component');
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
        path: 'heroes',
        component: heroes_component_1.HeroesComponent
    },
    {
        path: 'tests',
        component: test_component_1.TestComponent
    }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map