import { ModuleWithProviders, NgModule } from '@angular/core';
import { USER_TYPE_TEST_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class UserTypeTestConfigModule {
  static forRoot(): ModuleWithProviders<UserTypeTestConfigModule> {
    return {
      ngModule: UserTypeTestConfigModule,
      providers: [USER_TYPE_TEST_ROUTE_PROVIDERS],
    };
  }
}
