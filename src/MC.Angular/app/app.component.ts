import { Component }          from '@angular/core';

import './rxjs-extensions';

@Component({
    selector: 'my-app',

    template: `
    <nav>
      <a routerLink="/dashboard" routerLinkActive="active">Dashboard</a>
      <a routerLink="/heroes" routerLinkActive="active">Heroes</a>
    </nav>
    <div class="container">
    <router-outlet></router-outlet>
    </div>
  `,
})
export class AppComponent {
}