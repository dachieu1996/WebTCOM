import { Injectable, PLATFORM_ID, Inject } from '@angular/core';
import { BaseService } from './base.service';
import { TransferHttpService } from '@gorniv/ngx-universal';

@Injectable({
  providedIn: 'root'
})
export class ServiceTypeService extends BaseService {
  baseApiUrl = 'api/ServiceType/';
  constructor(http: TransferHttpService, @Inject(PLATFORM_ID) public platformId: Object) {
    super(http, platformId);
  }

  getAll() {
    return this.defaultGet(`${this.baseApiUrl}GetAll`);
  }

}
