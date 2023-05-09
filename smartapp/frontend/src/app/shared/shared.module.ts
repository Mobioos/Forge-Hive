import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MoodCardComponent } from './components/mood-card/mood-card.component';

import { TranslateModule } from '@ngx-translate/core';
import { IdeaCardComponent } from './components/idea-card/idea-card.component';
import { QuestionCardComponent } from './components/question-card/question-card.component';
import { ReportingCardComponent } from './components/reporting-card/reporting-card.component';

import { EventCardComponent } from './components/event-card/event-card.component';

@NgModule({
  declarations: [
    IdeaCardComponent,
    QuestionCardComponent,
    ReportingCardComponent,

    EventCardComponent,
    MoodCardComponent

  ],
  imports: [
    CommonModule,
    TranslateModule.forChild()
  ],
  exports: [
    IdeaCardComponent,
    QuestionCardComponent,
    ReportingCardComponent,

    EventCardComponent,
    MoodCardComponent

  ]
})
export class SharedModule { }

