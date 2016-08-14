import { Routes, RouterModule } from '@angular/router';

import { DashboardComponent }  from './components/dashboard.component';
import { HeroesComponent }     from './components/heroes.component';
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
        path: 'heroes',
        component: HeroesComponent
    },
    {
        path: 'tests',
        component: TestComponent
    }
];

export const routing = RouterModule.forRoot(appRoutes);