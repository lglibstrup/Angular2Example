import { Component, OnInit, Input } from '@angular/core';
import { Router, ActivatedRoute, Params }            from '@angular/router';

import { Item }          from '../model/item';
import { Network }        from '../model/network';
import { NetworkService } from '../services/network.service';
import { ItemTableComponent } from '../components/minor/item-table.component';
import { SearchBoxComponent } from '../components/minor/search-box.component';

@Component({
    selector: 'network',
    templateUrl: 'app/components/network-detail.component.html'
})
export class NetworkDetailComponent {
    error: any;
    navigated = false;
    network: Network = new Network();

    constructor(
        private router: Router,
        private networkService: NetworkService,
        private route: ActivatedRoute) {
    }

    ngOnInit() {
        this.route.params.forEach((params: Params) => {
            if (params['id'] !== undefined) {
                let id = +params['id'];
                this.navigated = true;
                this.networkService.getNetwork(id).then(network => this.network = network);
            } else {
                this.navigated = false;
                this.network = new Network();
            }
        });
    }
}