import { v4 as uuidv4 } from 'uuid';

interface IPort {
  portId: string;
  stewardId?: string;
  shipyardId?: string;
  boatIds: string[];
  merchantIds: string[];
  soldierIds: string[];
  name: string;
  developmentLevel: number;
  merchandise: number;
  incomeSilver: number;
  taxes: number;
  bailiffs: number;
  crime: number;
  isBeingDeveloped: boolean;
}

export class Port implements IPort {
  readonly portId: string;
  stewardId?: string;
  shipyard?: string;
  boatIds: string[];
  merchantIds: string[];
  soldierIds: string[];
  name: string;
  developmentLevel: number;
  merchandise: number;
  incomeSilver: number;
  taxes: number;
  bailiffs: number;
  crime: number;
  isBeingDeveloped: boolean;

  constructor() {
    this.portId = uuidv4();
    this.stewardId = undefined;
    this.shipyard = undefined;
    this.boatIds = [];
    this.merchantIds = [];
    this.soldierIds = [];
    this.name = '';
    this.developmentLevel = 1;
    this.merchandise = 0;
    this.incomeSilver = 0;
    this.taxes = 0;
    this.bailiffs = 0;
    this.crime = 0;
    this.isBeingDeveloped = false;
  }
}
