import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
    selector: 'search-box',
    template: `
<div class="row">
    <div class="col-md-12"> 
        <input #input type="text" (input)="update.emit(input.value)">
    </div>
</div>
`
})
export class SearchBoxComponent {
    @Output() searchTerm = new EventEmitter()

    ngOnInit() {
        this.searchTerm.emit('');
    }
}
