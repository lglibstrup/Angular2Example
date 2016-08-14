import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';

import { Network }        from '../model/network';
import { NetworkService } from '../services/network.service';

@Component({
    selector: 'dashboard',
    templateUrl: 'app/components/dashboard.component.html'
})
export class DashboardComponent implements OnInit {
    public networks: Network[] = [];

    constructor(
        private router: Router,
        private networkService: NetworkService) {
    }
    cd 
    ngOnInit() {
        this.networkService.getHeroes().then(networks => this.networks = networks);
    }
}