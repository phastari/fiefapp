import { v4 as uuidv4 } from 'uuid';

interface IShipyard {
  shipyardId: string;
  stewardId?: string;
  boatbuilderIds: string[];
  boatIds: string[];
  name: string;
  isBeingDeveloped: boolean;
  incomeSilver: number;
  smallDocks: number;
  mediumDocks: number;
  largeDocks: number;
  populationModifier: number;
}

export class Shipyard implements IShipyard {
  readonly shipyardId: string;
  stewardId?: string;
  boatbuilderIds: string[];
  boatIds: string[];
  name: string;
  isBeingDeveloped: boolean;
  incomeSilver: number;
  smallDocks: number;
  mediumDocks: number;
  largeDocks: number;
  populationModifier: number;

  constructor() {
    this.shipyardId = uuidv4();
    this.stewardId = undefined;
    this.boatbuilderIds = [];
    this.boatIds = [];
    this.name = '';
    this.isBeingDeveloped = false;
    this.incomeSilver = 0;
    this.smallDocks = 0;
    this.mediumDocks = 0;
    this.largeDocks = 0;
    this.populationModifier = 0;
  }
}
