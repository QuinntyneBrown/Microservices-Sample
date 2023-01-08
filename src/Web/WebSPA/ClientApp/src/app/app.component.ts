import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { map, of } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: true,
  imports: [
    CommonModule,
    HttpClientModule
  ]
})
export class AppComponent { 
  constructor(
    @Inject('BASE_URL') private readonly _baseUrl: string,
    private readonly _client: HttpClient
  ) { }

  public vm$ = this._client.get(this._baseUrl + "api/home/summaries").pipe(
    map(data => { data })
  )

}
