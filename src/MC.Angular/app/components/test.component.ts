import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';

import { Hero }                from '../model/hero';
import { HeroService }         from '../services/hero.service';

@Component({
    selector: 'testing',
    templateUrl: 'app/components/test.component.html'
})
export class TestComponent implements OnInit {
    constructor(
        private router: Router,
        private heroService: HeroService) { }

    ngOnInit() {
    }
}