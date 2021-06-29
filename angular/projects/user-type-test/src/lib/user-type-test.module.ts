import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { UserTypeTestComponent } from './components/user-type-test.component';
import { UserTypeTestRoutingModule } from './user-type-test-routing.module';

@NgModule({
  declarations: [UserTypeTestComponent],
  imports: [CoreModule, ThemeSharedModule, UserTypeTestRoutingModule],
  exports: [UserTypeTestComponent],
})
export class UserTypeTestModule {
  static forChild(): ModuleWithProviders<UserTypeTestModule> {
    return {
      ngModule: UserTypeTestModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<UserTypeTestModule> {
    return new LazyModuleFactory(UserTypeTestModule.forChild());
  }
}
