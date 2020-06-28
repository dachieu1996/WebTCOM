import { TransferHttpService } from '@gorniv/ngx-universal';
import { Injectable, PLATFORM_ID, Inject } from '@angular/core';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class IntroductionService extends BaseService {
  baseApiUrl='api/Introduction/';
  constructor(http: TransferHttpService, @Inject(PLATFORM_ID) public platformId: Object) {
    super(http, platformId);
  }

  getByLanguageId(languageId: number) {
    let params = {languageId};
    return this.defaultGet(`${this.baseApiUrl}GetByLanguageId`, params);
  }

}
