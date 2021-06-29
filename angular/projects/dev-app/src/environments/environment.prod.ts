import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'UserTypeTest',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44378',
    redirectUri: baseUrl,
    clientId: 'UserTypeTest_App',
    responseType: 'code',
    scope: 'offline_access UserTypeTest',
  },
  apis: {
    default: {
      url: 'https://localhost:44378',
      rootNamespace: 'UserTypeTest',
    },
    UserTypeTest: {
      url: 'https://localhost:44380',
      rootNamespace: 'UserTypeTest',
    },
  },
} as Environment;
