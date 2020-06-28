import { Default } from './../../core/constants/default';
import { RouteLink } from './../../core/constants/route-link';
import { ServiceTypeService } from './../../core/services/service-type.service';
import { ServiceTypeDetail } from 'src/app/core/models/service-type-detail';
import { ServiceTypeDetailService } from './../../core/services/service-type-detail.service';
import { Component, OnInit, PLATFORM_ID, Inject, Injector } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { BaseComponent } from '../base/base.component';

@Component({
  selector: 'app-service-type-page',
  templateUrl: './service-type-page.component.html',
  styleUrls: ['./service-type-page.component.css']
})
export class ServiceTypePageComponent extends BaseComponent implements OnInit {
  baseUrl = environment.BASE_URL;
  id: number;
  languageId: number = Default.languageId;
  serviceTypeDetail: ServiceTypeDetail = {} as ServiceTypeDetail;

  constructor(
    injector: Injector,
    @Inject(PLATFORM_ID) public platformId: Object,
    private route: ActivatedRoute,
    private router: Router,
    private serviceTypeDetailService: ServiceTypeDetailService
  ) {
    super(injector, platformId);
  }

  ngOnInit() {
    this.id = Number(this.route.snapshot.paramMap.get('id'));
    let languageIdParam = this.route.snapshot.queryParamMap.get('languageId');
    if (languageIdParam) {
      this.languageId = Number(languageIdParam);
    }
    else if (this.languageIdStorage && this.languageIdStorage != Default.languageId) {
      this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
        this.router.navigate([RouteLink.serviceType, this.id], { queryParams: { languageId: this.languageIdStorage } });
      });
    }

    this.getData();
  }

  getData() {
    this.serviceTypeDetailService.get(this.languageId, this.id).then(res => {
      if (res.data) this.serviceTypeDetail = res.data;
    });
  }

}
