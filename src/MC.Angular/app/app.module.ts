import { NgModule }       from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
import { FormsModule }    from '@angular/forms';

// Imports for loading & configuring the in-memory web api
import { HttpModule, XHRBackend } from '@angular/http';

import { AppComponent }   from './app.component';
import { routing }        from './app.routing';

import { HeroesComponent }      from './components/heroes.component';
import { DashboardComponent }   from './components/dashboard.component';
import { TestComponent }     from './components/test.component';

import { ItemTableComponent } from './components/minor/item-table.component';

import { HeroService }  from './services/hero.service';
import { NetworkService } from './services/networkservice';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        routing,
        HttpModule
    ],
    declarations: [
        AppComponent,
        HeroesComponent,
        DashboardComponent,
        ItemTableComponent,
        TestComponent
    ],
    providers: [
        HeroService,
        NetworkService
    ],
    bootstrap: [AppComponent]
})
export class AppModule {
}
