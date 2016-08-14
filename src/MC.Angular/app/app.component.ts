import { Component }        from '@angular/core';
import { Router }           from '@angular/router';
import { Network }          from './model/network';
import { NetworkService }   from './services/network.service';

import './rxjs-extensions';

@Component({
    selector: 'my-app',
    templateUrl: 'app/app.component.html'
})
export class AppComponent {
    public networks: Network[] = [];
    public selectedNetwork: Network

    constructor(
        private router: Router,
        private networkService: NetworkService) {
    }

    ngOnInit() {
        this.networkService.getHeroes().then(networks => this.networks = networks);
    }

    gotoNetwork(network: Network) {
        this.selectedNetwork = network;
        this.router.navigate(['network', network.networkId]);
    }
}