"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var router_1 = require('@angular/router');
var network_1 = require('../model/network');
var network_service_1 = require('../services/network.service');
var NetworkDetailComponent = (function () {
    function NetworkDetailComponent(router, networkService, route) {
        this.router = router;
        this.networkService = networkService;
        this.route = route;
        this.navigated = false;
        this.network = new network_1.Network();
    }
    NetworkDetailComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.params.forEach(function (params) {
            if (params['id'] !== undefined) {
                var id = +params['id'];
                _this.navigated = true;
                _this.networkService.getNetwork(id).then(function (network) { return _this.network = network; });
            }
            else {
                _this.navigated = false;
                _this.network = new network_1.Network();
            }
        });
    };
    NetworkDetailComponent = __decorate([
        core_1.Component({
            selector: 'network',
            templateUrl: 'app/components/network-detail.component.html'
        }), 
        __metadata('design:paramtypes', [router_1.Router, network_service_1.NetworkService, router_1.ActivatedRoute])
    ], NetworkDetailComponent);
    return NetworkDetailComponent;
}());
exports.NetworkDetailComponent = NetworkDetailComponent;
//# sourceMappingURL=network-detail.component.js.map