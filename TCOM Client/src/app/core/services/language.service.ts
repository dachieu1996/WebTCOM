import { TransferHttpService } from '@gorniv/ngx-universal';
import { Injectable, PLATFORM_ID, Inject } from '@angular/core';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class LanguageService extends BaseService {
  baseApiUrl = 'api/Language/';
  constructor(http: TransferHttpService, @Inject(PLATFORM_ID) public platformId: Object) {
    super(http, platformId);
  }

  getAll() {
    return this.defaultGet(`${this.baseApiUrl}GetAll`);
  }

}
