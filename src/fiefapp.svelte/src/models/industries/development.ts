import { Industry } from './industry';

interface IDevelopment {
  beingDevelopedId: string;
}

export class Development extends Industry implements IDevelopment {
  constructor(public beingDevelopedId: string, name: string) {
    super();

    this.beingDevelopedId = beingDevelopedId;
    this.name = 'Utveckla ' + name;
    this.needSteward = true;
  }
}
