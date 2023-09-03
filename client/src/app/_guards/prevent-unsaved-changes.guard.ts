import { CanDeactivateFn } from '@angular/router';
import { MemberEditComponent } from '../members/member-edit/member-edit.component';
import { inject } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

export const preventUnsavedChangesGuard: CanDeactivateFn<MemberEditComponent> = (component) => {
  const toastr = inject(ToastrService);
  if(component.editForm?.dirty){
   return confirm("Are you sure about that !!");

  }
  
  return true;
};
