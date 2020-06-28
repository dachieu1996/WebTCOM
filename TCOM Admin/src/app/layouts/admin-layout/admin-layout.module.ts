import { BaseComponent } from './../../admin/base/base.component';
import { DragulaModule } from 'ng2-dragula';
import { AngularEditorModule } from '@kolkov/angular-editor';
import { UploadOrderedImageComponent } from './../../shared/upload-ordered-image/upload-ordered-image.component';
import { LanguageComponent } from './../../admin/language/language.component';
import { CreateEditHomeComponent } from './../../admin/home/create-edit-home/create-edit-home.component';
import { HomeComponent } from './../../admin/home/home.component';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DragDropModule } from '@angular/cdk/drag-drop';
import { AdminLayoutRoutes } from './admin-layout.routing';
import { DashboardComponent } from '../../dashboard/dashboard.component';
import { UserProfileComponent } from '../../user-profile/user-profile.component';
import { TableListComponent } from '../../table-list/table-list.component';
import { TypographyComponent } from '../../typography/typography.component';
import { IconsComponent } from '../../icons/icons.component';
import { MapsComponent } from '../../maps/maps.component';
import { NotificationsComponent } from '../../notifications/notifications.component';
import { UpgradeComponent } from '../../upgrade/upgrade.component';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatRippleModule } from '@angular/material/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatSelectModule } from '@angular/material/select';
import { MatTabsModule } from '@angular/material/tabs'
import { MatTableModule } from '@angular/material/table';
import { MatDividerModule } from '@angular/material/divider';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { UploadImageComponent } from 'app/shared/upload-image/upload-image.component';
import { EditorComponent } from 'app/shared/editor/editor.component';
import { BrowserModule } from '@angular/platform-browser';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(AdminLayoutRoutes),
    FormsModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatRippleModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatTooltipModule,
    MatTabsModule,
    MatTableModule,
    MatDividerModule,
    DragulaModule,
    MatSnackBarModule,
    AngularEditorModule,
    DragDropModule
  ],
  declarations: [
    DashboardComponent,
    UserProfileComponent,
    TableListComponent,
    TypographyComponent,
    IconsComponent,
    MapsComponent,
    NotificationsComponent,
    UpgradeComponent,
    HomeComponent,
    CreateEditHomeComponent,
    LanguageComponent,
    UploadOrderedImageComponent,
    UploadImageComponent,
    EditorComponent
  ]
})

export class AdminLayoutModule { }
