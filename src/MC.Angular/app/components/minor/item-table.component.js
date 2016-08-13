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
var ItemTableComponent = (function () {
    function ItemTableComponent() {
    }
    __decorate([
        core_1.Input(), 
        __metadata('design:type', Array)
    ], ItemTableComponent.prototype, "items", void 0);
    ItemTableComponent = __decorate([
        core_1.Component({
            selector: 'item-table',
            template: "\n                <table class=\"table table-striped\">\n                <thead>\n                    <tr>\n                        <td style=\"width:46px\">#</td>\n                        <td></td>\n                        <td>Item</td>\n                    </tr>\n                </thead>\n                <tbody>\n                    <tr *ngFor=\"let item of items\">\n                        <td>{{ item.blockId }}:{{ item.blockMetaData }}</td>\n                        <td>{{ item.name }}</td>\n                        <td>{{ item.numberStored }}</td>\n                    </tr>\n                </tbody>\n                </table>\n"
        }), 
        __metadata('design:paramtypes', [])
    ], ItemTableComponent);
    return ItemTableComponent;
}());
exports.ItemTableComponent = ItemTableComponent;
//# sourceMappingURL=item-table.component.js.map