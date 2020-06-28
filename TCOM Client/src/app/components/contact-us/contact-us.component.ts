import { Default } from './../../core/constants/default';
import { RouteLink } from './../../core/constants/route-link';
import { Contact } from './../../core/models/contact';
import { ContactService } from './../../core/services/contact.service';
import { Component, OnInit, Injector, PLATFORM_ID, Inject } from '@angular/core';
import { environment } from './../../../environments/environment';
import { BaseComponent } from '../base/base.component';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrls: ['./contact-us.component.css']
})
export class ContactUsComponent extends BaseComponent implements OnInit {
  languageId: number = Default.languageId;
  contact: Contact = {} as Contact;
  constructor(
    injector: Injector,
    @Inject(PLATFORM_ID) public platformId: Object,
    private contactService: ContactService,
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
        this.router.navigate([RouteLink.contact], { queryParams: { languageId: this.languageIdStorage } });
      });
    }

    this.getData();
  }


  getData() {
    this.contactService.getByLanguageId(this.languageId).then(res => {
      if (res.data) {
        this.contact = res.data;
      }
    });
  }

}
