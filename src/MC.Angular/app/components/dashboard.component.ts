﻿import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';

import { Hero }        from '../model/hero';
import { HeroService } from '../services/hero.service';

@Component({
    selector: 'my-dashboard',
    templateUrl: 'app/components/dashboard.component.html',
    styleUrls: ['app/components/dashboard.component.css']
})
export class DashboardComponent implements OnInit {
    public heroes: Hero[] = [];

    constructor(
        private router: Router,
        private heroService: HeroService) {
    }

    ngOnInit() {
        this.heroService.getHeroes()
            .then(heroes => this.heroes = heroes);
    }

    gotoDetail(hero: Hero) {
        let link = ['/detail', hero.id];
        this.router.navigate(link);
    }
}