import type { Development } from './industries/development';

interface IShipyard {
  id: string;
  stewardId?: string;
  boatbuilderIds: string[];
  boatIds: string[];
  name: string;
  development?: Development;
  incomeSilver: number;
  smallDocks: number;
  mediumDocks: number;
  largeDocks: number;
  populationModifier: number;
}

export class Shipyard implements IShipyard {
  id: string;
  stewardId?: string;
  boatbuilderIds: string[];
  boatIds: string[];
  name: string;
  development?: Development;
  incomeSilver: number;
  smallDocks: number;
  mediumDocks: number;
  largeDocks: number;
  populationModifier: number;

  constructor() {
    this.id = '';
    this.stewardId = undefined;
    this.boatbuilderIds = [];
    this.boatIds = [];
    this.name = '';
    this.development = undefined;
    this.incomeSilver = 0;
    this.smallDocks = 0;
    this.mediumDocks = 0;
    this.largeDocks = 0;
    this.populationModifier = 0;
  }
}
