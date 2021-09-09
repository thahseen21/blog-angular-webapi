// Angular Modules
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class Constants {
  public readonly BASE_URL: string = 'https://localhost:5001/';
  public readonly WEATHERFORECAST: string = 'blog';
  public readonly ADDCOMMENT = 'comment/addcomment'
}
