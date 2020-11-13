import { v4 as uuidv4 } from 'uuid';

interface IMarket {
  marketId: string;
  stewardId?: string;
  merchantIds: string[];
  soldierIds: string[];
  name: string;
  developmentLevel: number;
  merchandise: number;
  silver: number;
  base: number;
  luxury: number;
  taxes: number;
  bailiffs: number;
  crime: number;
  isBeingDeveloped: boolean;
}

export class Market implements IMarket {
  marketId: string;
  stewardId?: string;
  merchantIds: string[];
  soldierIds: string[];
  name: string;
  developmentLevel: number;
  merchandise: number;
  silver: number;
  base: number;
  luxury: number;
  taxes: number;
  bailiffs: number;
  crime: number;
  isBeingDeveloped: boolean;

  constructor() {
    this.marketId = uuidv4();
    this.stewardId = undefined;
    this.merchantIds = [];
    this.soldierIds = [];
    this.name = '';
    this.developmentLevel = 1;
    this.merchandise = 0;
    this.silver = 0;
    this.base = 0;
    this.luxury = 0;
    this.taxes = 0;
    this.bailiffs = 0;
    this.crime = 0;
    this.isBeingDeveloped = false;
  }
}
