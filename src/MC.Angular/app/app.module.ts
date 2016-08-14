import { NgModule }       from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
import { FormsModule }    from '@angular/forms';
import { AUTH_PROVIDERS } from 'angular2-jwt';

// Imports for loading & configuring the in-memory web api
import { HttpModule, XHRBackend } from '@angular/http';

import { AppComponent }   from './app.component';
import { routing }        from './app.routing';

import { LoginComponent }      from './components/login.component';
import { DashboardComponent }   from './components/dashboard.component';
import { NetworkDetailComponent }   from './components/network-detail.component';
import { TestComponent }     from './components/test.component';
import { ItemTableComponent } from './components/minor/item-table.component';
import { SearchBoxComponent } from './components/minor/search-box.component';

import { HeroService }  from './services/hero.service';
import { NetworkService } from './services/network.service';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        routing,
        HttpModule
    ],
    declarations: [
        AppComponent,
        LoginComponent,
        DashboardComponent,
        TestComponent,
        ItemTableComponent,
        NetworkDetailComponent,
        SearchBoxComponent,
    ],
    providers: [
        HeroService,
        NetworkService,
    ],
    bootstrap: [AppComponent]
})
export class AppModule {
}
