import { Industry } from './industry';

interface IDevelopment {
  beingDeveloped: Industry | undefined;
}

export class Development extends Industry implements IDevelopment {
  beingDeveloped: Industry | undefined;

  constructor() {
    super();

    this.name = '';
    this.needSteward = true;
  }
}
