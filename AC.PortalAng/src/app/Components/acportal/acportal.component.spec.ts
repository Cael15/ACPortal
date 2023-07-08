import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ACPortalComponent } from './acportal.component';

describe('ACPortalComponent', () => {
  let component: ACPortalComponent;
  let fixture: ComponentFixture<ACPortalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ACPortalComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ACPortalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
