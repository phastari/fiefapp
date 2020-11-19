<script lang="ts">
  import FiefSelector from '../../../components/fief-selector/fief-selector.svelte';
  import { fiefs, index } from '../../../stores/fiefs';
  import type { Fief } from '../../../models/fief';
  import { selectionAlternatives } from '../../../stores/selection-alternatives';

  let fief: Fief;
  $: fief = $fiefs[$index];
</script>

<style>
  span + input + span {
    width: 1px;
  }

  .special-height {
    height: calc(8 * var(--line-height) + 3);
    min-height: 123px;
    resize: none;
  }
</style>

<div class="container">
  <div class="column">
    <h2>Information</h2>
    <div class="row">
      <FiefSelector />
    </div>
    <div class="row">
      <span>Arvstyp</span>
      <select class="large-field" bind:value={fief.inheritance} >
        {#each $selectionAlternatives.inheritances as inheritance}
          <option>{inheritance.name}</option>
        {/each}
      </select>
    </div>
    <div class="full-width-row">
      <textarea class="full-width-field special-height" readonly rows="8" bind:value={fief.inheritance.description} />
    </div>
    <div class="row">
      <span>Vägnät</span> 
      <select class="large-field" bind:value={fief.road} >
        {#each $selectionAlternatives.roads as road}
          <option>{road.name}</option>
        {/each}
      </select>
    </div>
    <div class="row">
      <span>Tunnland</span>
      <input class="medium-field" type="number" bind:value={fief.acres} />
    </div>
    <div class="row">
      <span>Jordbruk</span>
      <input class="medium-field" type="number" bind:value={fief.farmlandAcres} />
    </div>
    <div class="row">
      <span>Djurhållning</span>
      <input class="medium-field" type="number" bind:value={fief.pastureAcres} />
    </div>
    <div class="row">
      <span>Skogsmark</span>
      <input class="medium-field" type="number" bind:value={fief.woodlandAcres} />
    </div>
    <div class="row">
      <span>Avverkad skogsmark</span>
      <input class="medium-field" type="number" bind:value={fief.fellingAcres} />
    </div>
  </div>
  <div class="column">
    <h2>Kvaliter och utvecklingsnivåer</h2>
    <div class="row">
      <span>Djurhållning</span>
      <input class="small-field" type="number" bind:value={fief.animalHusbandryQuality} />
      <span></span>
      <input class="small-field" type="number" bind:value={fief.animalHusbandryDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Jordbruk</span>
      <input class="small-field" type="number" bind:value={fief.agriculturalDevelopmentLevel} />
      <span></span>
      <input class="small-field" type="number" bind:value={fief.agriculturalQuality} />
    </div>
    <div class="row">
      <span>Jakt</span>
      <input class="small-field" type="number" bind:value={fief.huntingQuality} />
      <span></span>
      <input class="small-field" type="number" bind:value={fief.huntingDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Fiske</span>
      <input class="small-field" type="number" bind:value={fief.fishingQuality} />
      <span></span>
      <input class="small-field" type="number" bind:value={fief.fishingDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Malm</span>
      <input class="small-field" type="number" bind:value={fief.oreQuality} />
      <span></span>
      <input class="small-field" type="number" bind:value={fief.oreDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Skogsbruk</span>
      <input class="small-field" type="number" bind:value={fief.woodlandDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Utbildning</span>
      <input class="small-field" type="number" bind:value={fief.educationDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Medicin</span>
      <input class="small-field" type="number" bind:value={fief.healthcareDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Militär</span>
      <input class="small-field" type="number" bind:value={fief.militaryDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Sjöfart</span>
      <input class="small-field" type="number" bind:value={fief.seafaringDevelopmentLevel} />
    </div>
  </div>
</div>
