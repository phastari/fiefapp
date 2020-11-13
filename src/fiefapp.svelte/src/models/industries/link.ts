import { Industry } from './industry';

export enum LinkType {
  FIEF = 'FIEF',
  MARKET = 'MARKET',
  PORT = 'PORT',
  SHIPYARD = 'SHIPYARD',
}

interface ILink {
  id: string;
  type: LinkType;
}

export class Link extends Industry implements ILink {
  constructor(
    public type: LinkType,
    public id: string,
    name: string = 'default',
    fief: string = ''
  ) {
    super();

    this.id = id;
    this.needSteward = true;
    this.type = type;

    switch (type) {
      case LinkType.FIEF: {
        if (name === 'default') {
          this.name = 'Förläningen';
        } else {
          this.name = 'Förläningen ' + name;
        }
        break;
      }

      case LinkType.MARKET: {
        if (name === 'default') {
          this.name = 'Marknaden';
        } else if (name === '') {
          this.name = 'Marknaden i ' + fief;
        } else {
          this.name = 'Marknaden ' + name + ' i ' + fief;
        }
        break;
      }

      case LinkType.PORT: {
        if (name === '') {
          this.name = 'Hamnen i ' + fief;
        } else {
          this.name = 'Hamnen ' + name + ' i ' + fief;
        }
        break;
      }

      case LinkType.SHIPYARD: {
        if (name === '') {
          this.name = 'Varvet i ' + fief;
        } else {
          this.name = 'Varvet ' + name + ' i ' + fief;
        }
        break;
      }
    }
  }
}
