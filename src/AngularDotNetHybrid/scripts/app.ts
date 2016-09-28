import { Component } from '@angular/core';
@Component({
    selector: 'my-app',
    templateUrl: 'views/app.html',
})
export class AppComponent {
    title: string = 'Test!';
    body: string = 'This is the body of the page.';
}