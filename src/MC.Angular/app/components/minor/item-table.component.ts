import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Item } from '../../model/item';

@Component({
    selector: 'item-table',
    template: `
                <table class="table table-striped">
                <thead>
                    <tr>
                        <td style="width:46px">#</td>
                        <td></td>
                        <td>Item</td>
                    </tr>
                </thead>
                <tbody>
                    <tr *ngFor="let item of items">
                        <td>{{ item.blockId }}:{{ item.blockMetaData }}</td>
                        <td>{{ item.name }}</td>
                        <td>{{ item.numberStored }}</td>
                    </tr>
                </tbody>
                </table>
`
})
export class ItemTableComponent {
    @Input() items: Item[];
}