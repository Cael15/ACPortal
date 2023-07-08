import { TestBed } from '@angular/core/testing';

import { EsignatureRecipientService } from './esignature-recipient.service';

describe('EsignatureRecipientService', () => {
  let service: EsignatureRecipientService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EsignatureRecipientService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
