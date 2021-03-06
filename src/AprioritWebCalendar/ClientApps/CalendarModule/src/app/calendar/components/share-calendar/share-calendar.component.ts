import { Component, OnInit } from '@angular/core';
import { DialogService } from 'ng2-bootstrap-modal';
import { CalendarService } from '../../services/calendar.service';
import { User } from '../../../authentication/models/user';
import { UserCalendar } from '../../models/user.calendar';
import { CustomDialogComponent } from '../../../services/custom.dialog.component';

export interface IShareCalendarModel {
    Id: Number;
    Name: string;
    Owner: User;
}

@Component({
    selector: 'app-share-calendar',
    templateUrl: './share-calendar.component.html'
})
export class ShareCalendarComponent 
                        extends CustomDialogComponent<IShareCalendarModel, boolean> 
                        implements IShareCalendarModel, OnInit {  
    Id: Number;
    Name: string;
    Owner: User;

    public sharedUsers: UserCalendar[] = [];
    isError: boolean = false;

    constructor(
        public dialogService: DialogService,
        private calendarService: CalendarService
    ) {
        super(dialogService);
     }


    ngOnInit(): void {
        this.calendarService.getSharedUsers(this.Id)
            .subscribe((users: UserCalendar[]) => {
                if (users != undefined)
                    this.sharedUsers = users;
            },
            (resp: Response) => {
                this.isError = true;
            });
    }

    addShared(userCalendar: UserCalendar) {
        this.sharedUsers.push(userCalendar);
    }
}
