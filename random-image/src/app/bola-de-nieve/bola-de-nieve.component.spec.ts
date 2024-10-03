import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BolaDeNieveComponent } from './bola-de-nieve.component';

describe('BolaDeNieveComponent', () => {
  let component: BolaDeNieveComponent;
  let fixture: ComponentFixture<BolaDeNieveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [BolaDeNieveComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BolaDeNieveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
