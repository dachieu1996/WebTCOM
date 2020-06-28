import { CreateLanguage } from './../models/language';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class LanguageService extends BaseService {
  baseApiUrl: string = "api/Language/";
  constructor(http: HttpClient) {
    super(http);
  }

  getAll() {
    return this.defaultGet(this.baseApiUrl + "GetAll");
  }

  add(language: CreateLanguage) {
    return this.defaultPost(this.baseApiUrl + "Add", language);
  }

  update(obj: CreateLanguage) {
    let data = obj;
    return this.defaultPut(this.baseApiUrl + 'Update', data);
  }

  delete(id: number) {
    let params = { id: id };
    return this.defaultDelete(this.baseApiUrl + "Delete", params);
  }
}
