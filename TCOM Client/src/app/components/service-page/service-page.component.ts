import { RouteLink } from './../../core/constants/route-link';
import { Default } from './../../core/constants/default';
import { ServiceTypeService } from './../../core/services/service-type.service';
import { Component, OnInit, Injector, Inject, PLATFORM_ID } from '@angular/core';
import { BaseComponent } from '../base/base.component';
import { environment } from 'src/environments/environment';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-service-page',
  templateUrl: './service-page.component.html',
  styleUrls: ['./service-page.component.css']
})
export class ServicePageComponent extends BaseComponent implements OnInit {
  serviceType = [];
  baseUrl = environment.BASE_URL;
  languageId: number = Default.languageId;

  constructor(
    injector: Injector,
    @Inject(PLATFORM_ID) public platformId: Object,
    private serviceTypeService: ServiceTypeService,
    private router: Router,
    private route: ActivatedRoute
  ) {
    super(injector, platformId);
  }

  ngOnInit() {
    let languageIdParam = this.route.snapshot.queryParamMap.get('languageId');
    if (languageIdParam) {
      this.languageId = Number(languageIdParam);
    }
    else if (this.languageIdStorage && this.languageIdStorage != Default.languageId) {
      this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
        this.router.navigate([RouteLink.service], { queryParams: { languageId: this.languageIdStorage } });
      });
    }
    this.getAllServiceType();
  }

  getAllServiceType() {
    this.serviceTypeService.getAll().then(res => {
      if (res.data) {
        this.serviceType = res.data;
      }
    });
  }
}
