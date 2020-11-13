import { v4 as uuidv4 } from 'uuid';
import { InheritanceAlternative } from './settings/inheritance-alternative';

interface IInheritance {
  inheritanceId: string;
  type: InheritanceType;
  name: string;
  description: string;
}

export enum InheritanceType {
  HEREDITARY = 'HEREDITARY',
  NOT_HEREDITARY = 'NOT_HEREDITARY',
  PLEDGE = 'PLEDGE',
  LEASE = 'LEASE',
}

export class Inheritance implements IInheritance {
  readonly inheritanceId: string;

  constructor(
    public type: InheritanceType,
    public name: string,
    public description: string
  ) {
    this.inheritanceId = uuidv4();
  }

  public createAlternative(): InheritanceAlternative {
    return new InheritanceAlternative(
      this.type.toString(),
      this.name,
      this.description
    );
  }
}

export const inheritances: Inheritance[] = [
  new Inheritance(
    InheritanceType.HEREDITARY,
    'Ärftligt län',
    'Vasallen får länet mot att han utför vapentjänst och svär trohet till länsherren. När vasallen dör så ärver hans arvinge länet. Har vasallen inte har någon arvinge så går länet tillbaka till länsherren.'
  ),
  new Inheritance(
    InheritanceType.NOT_HEREDITARY,
    'Icke ärftligt län',
    'Vasallen får länet mot att han utför vapentjänst och svär trohet till länsherren. När vasallen dör så går länet tillbaka till länsherren.'
  ),
  new Inheritance(
    InheritanceType.PLEDGE,
    'Pantlän',
    'Ibland händer det att en länsherre måste låna pengar, till exempel i tider av ofred. Länsherren kan då skänka långivaren ett län att disponera fritt tills dess att lånet är återbetalat.'
  ),
  new Inheritance(
    InheritanceType.LEASE,
    'Län på avgift',
    'Vasallen betalar en fast avgift till sin länsherre mot att han fritt får disponera länets inkomster.'
  ),
];
