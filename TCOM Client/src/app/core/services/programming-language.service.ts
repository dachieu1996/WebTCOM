import { TransferHttpService } from '@gorniv/ngx-universal';
import { Injectable, PLATFORM_ID, Inject } from '@angular/core';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class ProgrammingLanguageService extends BaseService{
  baseApiUrl = 'api/ProgrammingLanguage/';
  constructor(http: TransferHttpService, @Inject(PLATFORM_ID) public platformId: Object) {
    super(http, platformId);
  }

  getForHome() {
    return this.defaultGet(`${this.baseApiUrl}GetForHome`);
  }

}
