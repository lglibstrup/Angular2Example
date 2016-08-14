import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { SearchPipe } from './pipe'
import { Item } from '../../model/item';

@Component({
    selector: 'item-table',
    pipes: [SearchPipe],
    template: `
                <table class="table table-striped">
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
    @Input() term: string;
}