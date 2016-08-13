﻿import { NgModule }       from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
import { FormsModule }    from '@angular/forms';

// Imports for loading & configuring the in-memory web api
import { HttpModule, XHRBackend } from '@angular/http';

import { AppComponent }   from './app.component';
import { routing }        from './app.routing';

import { HeroesComponent }      from './components/heroes.component';
import { DashboardComponent }   from './components/dashboard.component';
import { HeroDetailComponent }  from './components/hero-detail.component';
import { HeroSearchComponent }  from './components/hero-search.component';

import { HeroService }  from './services/hero.service';

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
        HeroDetailComponent,
        HeroSearchComponent
    ],
    providers: [
        HeroService
    ],
    bootstrap: [AppComponent]
})
export class AppModule {
}
