import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
    selector: 'search-box',
    template: `
<div class="row">
    <div class="col-md-12"> 
        <input #input type="text" class="form-control" (input)="update.emit(input.value)">
    </div>
</div>
`
})
export class SearchBoxComponent {
    @Output() update = new EventEmitter()

    ngOnInit() {
        this.update.emit('');
    }
}
