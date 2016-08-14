import { Pipe, PipeTransform } from '@angular/core';
import { Item } from '../../model/item';


@Pipe({
    name: "SearchPipe"
})
export class SearchPipe implements PipeTransform {
    transform(value: Item[]) {
        return value.filter(p => p.name.startsWith('No'));
    }
}