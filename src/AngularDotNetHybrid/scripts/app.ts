﻿import { Component } from '@angular/core';
import { Http, HTTP_PROVIDERS } from '@angular/http';

@Component({
    selector: 'my-app',
    templateUrl: 'views/app.html',
    providers: [HTTP_PROVIDERS]
})

export class AppComponent {
    title: string = 'Test!';
    body: string = 'This is the body of the page.';
    tasks = [];
    allTasks: Task[] = [{ id: 0, description: "Walk the Dog" }, { id: 1, description: "Buy Milk" }, { id: 2, description: "Do Laundry" }];
    constructor(private http: Http) {}
         getTasks() {
             alert("Your event emitter works!");
             debugger;
            this.http.get("/Home/GetTasks").subscribe(res => console.log(res));
        }
}

export class Task {
    constructor(public id: number, public description: string) { };
}