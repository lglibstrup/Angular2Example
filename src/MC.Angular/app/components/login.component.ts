﻿import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';

@Component({
    selector: 'login',
    templateUrl: 'app/components/login.component.html'
})
export class LoginComponent implements OnInit {
    constructor(
        private router: Router) { }

    ngOnInit() {
    }
}