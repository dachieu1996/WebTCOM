import { TransferHttpService } from '@gorniv/ngx-universal';
import { Injectable, Inject, PLATFORM_ID } from '@angular/core';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class ContactService extends BaseService {
  baseApiUrl = 'api/Contact/';
  constructor(http: TransferHttpService, @Inject(PLATFORM_ID) public platformId: Object) {
    super(http, platformId);
  }

  getByLanguageId(languageId: number) {
    let params = {languageId};
    return this.defaultGet(`${this.baseApiUrl}GetByLanguageId`, params);

  }

}
