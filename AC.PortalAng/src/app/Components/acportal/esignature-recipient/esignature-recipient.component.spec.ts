import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EsignatureRecipientComponent } from './esignature-recipient.component';

describe('EsignatureRecipientComponent', () => {
  let component: EsignatureRecipientComponent;
  let fixture: ComponentFixture<EsignatureRecipientComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EsignatureRecipientComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EsignatureRecipientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
