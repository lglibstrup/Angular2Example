import { Routes, RouterModule } from '@angular/router';

import { DashboardComponent }  from './components/dashboard.component';
import { NetworkDetailComponent }   from './components/network-detail.component';
import { TestComponent }     from './components/test.component';

const appRoutes: Routes = [
    {
        path: '',
        redirectTo: '/dashboard',
        pathMatch: 'full'
    },
    {
        path: 'dashboard',
        component: DashboardComponent
    },
    {
        path: 'tests',
        component: TestComponent
    },
    {
        path: 'network',
        component: NetworkDetailComponent
    },
    {
        path: 'network/:id',
        component: NetworkDetailComponent
    }
];

export const routing = RouterModule.forRoot(appRoutes);