import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ApplicationModule, APP_INITIALIZER } from '@angular/core';

import { AppComponent } from './app.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { HttpModule, Http, XHRBackend, RequestOptions } from '@angular/http';

import { BootstrapModalModule, DialogService, DialogComponent } from 'ng2-bootstrap-modal';
import { ColorPickerModule } from 'ngx-color-picker';
import { ContextmenuModule } from 'ng2-contextmenu';
import { TypeaheadModule, ButtonsModule, TooltipModule, TimepickerModule, BsDatepickerModule } from 'ngx-bootstrap';
import { ToastModule } from 'ng2-toastr/ng2-toastr';
import { PopoverModule } from 'ngx-bootstrap';
import { ClickOutsideModule } from 'ng-click-outside';
import { HotkeyModule } from 'angular2-hotkeys';
import { TimezonePickerModule } from 'ng2-timezone-selector';
import { ReCaptchaModule } from 'angular5-recaptcha';

import { AgmCoreModule } from '@agm/core';

import { CalendarModule as ngCalendarModule } from 'angular-calendar';

import { AuthPanelComponent } from './authentication/components/auth-panel/auth-panel.component';

import { AuthorizeGuard } from './guards/authorize.guard';
import { AnonymousGuard } from './guards/anonymous.guard';

import { AuthenticationService } from './authentication/services/authentication.service';

import { routing } from './app.routing';
import { AlertComponent } from './shared/alert/alert.component';
import { AlertArrayComponent } from './shared/alert-array/alert-array.component';

import { EqualTextValidator } from 'angular2-text-equality-validator';
import { CustomHttp } from './services/custom.http';
import { CalendarService } from './calendar/services/calendar.service';
import { MainScreenComponent } from './calendar/components/main-screen/main-screen.component';
import { LeftCalendarMenuComponent } from './calendar/components/left-calendar-menu/left-calendar-menu.component';
import { CalendarCreateComponent } from './calendar/components/calendar-create/calendar-create.component';
import { CalendarEditComponent } from './calendar/components/calendar-edit/calendar-edit.component';
import { CalendarDeleteComponent } from './calendar/components/calendar-delete/calendar-delete.component';
import { ShareCalendarComponent } from './calendar/components/share-calendar/share-calendar.component';
import { SharedUsersListComponent } from './calendar/components/shared-users-list/shared-users-list.component';
import { UserService } from './services/user.service';
import { SelectUserShareComponent } from './calendar/components/select-user-share/select-user-share.component';
import { CalendarViewSwitcherComponent } from './calendar/components/calendar-view-switcher/calendar-view-switcher.component';
import { AddEventButtonComponent } from './calendar/components/add-event-button/add-event-button.component';
import { EventService } from './event/services/event.service';
import { EventCreateComponent } from './event/components/event-create/event-create.component';
import { EventPeriodComponent } from './event/components/event-period/event-period.component';
import { EventLocationComponent } from './event/components/event-location/event-location.component';
import { EventEditComponent } from './event/components/event-edit/event-edit.component';
import { EventDeleteComponent } from './event/components/event-delete/event-delete.component';
import { EventMoveComponent } from './event/components/event-move/event-move.component';
import { EventShareComponent } from './event/components/event-share/event-share.component';
import { EventShareUsersComponent } from './event/components/event-share-users/event-share-users.component';
import { EventSelectUserShareComponent } from './event/components/event-select-user-share/event-select-user-share.component';
import { EventSearchComponent } from './event/components/event-search/event-search.component';
import { InvitationsIncomingComponent } from './invitation/components/invitations-incoming/invitations-incoming.component';
import { InvitationsIncomingButtonComponent } from './invitation/components/invitations-incoming-button/invitations-incoming-button.component';
import { InvitationService } from './invitation/services/invitation.service';
import { InvitationViewComponent } from './invitation/components/invitation-view/invitation-view.component';
import { CalendarExportComponent } from './calendar/components/calendar-export/calendar-export.component';
import { CalendarIcalService } from './calendar/services/calendar.ical.service';
import { CalendarImportComponent } from './calendar/components/calendar-import/calendar-import.component';
import { CalendarImportPreviewComponent } from './calendar/components/calendar-import-preview/calendar-import-preview.component';
import { DateFormatPipe } from './pipes/date.format.pipe';
import { NotificationListener } from './notification/notification.listener';
import { PushNotificationService } from './services/push.notification.service';
import { AuthFormComponent } from './authentication/components/auth-form/auth-form.component';
import { Router } from '@angular/router';
import { InvitationListener } from './invitation/services/invitation.listener';
import { CalendarListener } from './calendar/services/calendar.listener';
import { EventDetailsComponent } from './event/components/event-details/event-details.component';
import { DateTimeLocalPipe } from './pipes/date.time.local.pipe';
import { TimeLocalPipe } from './pipes/time.local.pipe';
import { DateLocalPipe } from './pipes/date.local.pipe';
import { EventLocationViewComponent } from './event/components/event-location-view/event-location-view.component';
import { MaxTextLengthPipe } from './pipes/max.text.length.pipe';
import { SettingsMainComponent } from './settings/components/settings-main/settings-main.component';
import { SettingsTimezoneComponent } from './settings/components/settings-timezone/settings-timezone.component';
import { SettingsService } from './settings/services/settings.service';
import { SettingsTelegramComponent } from './settings/components/settings-telegram/settings-telegram.component';
import { TelegramService } from './settings/services/telegram.service';
import { TelegramListener } from './settings/services/telegram.listener';
import { PeriodTypePipe } from './pipes/period.type.pipe';
import { CustomDialogService } from './services/custom.dialog.service';
import { CustomDialogComponent } from './services/custom.dialog.component';
import { CountdownComponent } from './shared/countdown/countdown.component';

@NgModule({
  declarations: [
    AppComponent,
    AuthPanelComponent,
    AuthFormComponent,
    AlertComponent,
    AlertArrayComponent,
    MainScreenComponent,
    LeftCalendarMenuComponent,
    CalendarCreateComponent,
    CalendarEditComponent,
    CalendarDeleteComponent,
    ShareCalendarComponent,
    SharedUsersListComponent,
    SelectUserShareComponent,
    CalendarViewSwitcherComponent,
    AddEventButtonComponent,
    EventCreateComponent,
    EventPeriodComponent,
    EventLocationComponent,
    EventEditComponent,
    EventDeleteComponent,
    EventMoveComponent,
    EventShareComponent,
    EventShareUsersComponent,
    EventSelectUserShareComponent,
    EventSearchComponent,
    InvitationsIncomingComponent,
    InvitationsIncomingButtonComponent,
    InvitationViewComponent,
    CalendarExportComponent,
    CalendarImportComponent,
    CalendarImportPreviewComponent,
    EventDetailsComponent,
    EventLocationViewComponent,

    SettingsMainComponent,
    SettingsTimezoneComponent,
    SettingsTelegramComponent,

    DateFormatPipe,
    DateLocalPipe,
    DateTimeLocalPipe,
    TimeLocalPipe,
    MaxTextLengthPipe,
    PeriodTypePipe,
    CountdownComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    BrowserAnimationsModule,

    BootstrapModalModule,
    ColorPickerModule,
    ContextmenuModule,
    TypeaheadModule.forRoot(),
    ToastModule.forRoot(),
    ButtonsModule.forRoot(),
    TooltipModule.forRoot(),
    PopoverModule.forRoot(),

    BsDatepickerModule.forRoot(),
    TimepickerModule.forRoot(),
    ClickOutsideModule,
    HotkeyModule.forRoot(),
    TimezonePickerModule,
    ReCaptchaModule,

    ngCalendarModule.forRoot(),
    
    AgmCoreModule.forRoot({
        apiKey: 'AIzaSyBuPpVTIGkimz2VGPdGP5uSYkH4z43zQXM'
    }),

    routing
  ],
  providers: [
    NotificationListener,
    InvitationListener,
    CalendarListener,
    TelegramListener,
    
    {
        provide: CustomHttp,
        deps: [XHRBackend, RequestOptions, Router],
        useFactory: (backend, options) => {
            var customHttp = new CustomHttp(backend, options);
            customHttp.InitializeToken();
            return customHttp;
        }
    },

    {
        provide: AuthenticationService,
        deps: [Http, CustomHttp, Router, CalendarListener, InvitationListener, NotificationListener, TelegramListener],
        useFactory: (http: Http, customHttp: CustomHttp, router: Router, calListener: CalendarListener,
                invListener: InvitationListener,
                notifListener: NotificationListener,
                telegramListener: TelegramListener) => {
            
            var authService = new AuthenticationService(http, customHttp, router, calListener, invListener, notifListener, telegramListener);
            authService.InitializeUser();
            return authService;
        }
    },

    AuthorizeGuard,
    AnonymousGuard,

    CalendarService,
    UserService,
    EventService,
    InvitationService,
    CalendarIcalService,
    SettingsService,
    TelegramService,

    PushNotificationService,

    {
        provide: DialogService,
        useClass: CustomDialogService
    }
  ],
  bootstrap: [AppComponent],
  entryComponents: [
      CalendarCreateComponent,
      CalendarEditComponent,
      CalendarDeleteComponent,
      ShareCalendarComponent,
      CalendarExportComponent,
      CalendarImportComponent,

      EventCreateComponent,
      EventEditComponent,
      EventDeleteComponent,
      EventMoveComponent,
      EventShareComponent,
      EventDetailsComponent
    ]
})
export class CalendarModule { }
