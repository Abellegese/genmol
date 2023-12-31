
# Generative Molecule Designer

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![GPLv3 License](https://img.shields.io/badge/License-GPL%20v3-yellow.svg)](https://opensource.org/licenses/)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](http://www.gnu.org/licenses/agpl-3.0)

This project used a vanilla transformer and Graph transformer to predict a molecule as a string of smiles by sampling from a distribution and by providing the disease protein to get the corresponding drugs. Using the decoder only transformer to decode a smiles of molecules to high-dimensional
representation. There is also another models that can be used using UI. By uploading the 3D protein structure we can generate the drugs candidate. The candidate can further be optimized for the docking score.

## Usage

Download the files from this repo then runs the code below

```bash
  python3 train.py --path 'data/smiles.csv' --epoch=10 --ts 0.1
```
### Generate
```bash
  python3 sample.py
```
## Output
<img src="https://th.bing.com/th/id/R.ed5e8b15a86be768e7df420458411681?rik=VqqbYRUSv5tOzg&riu=http%3a%2f%2fwww.cheminformania.com%2fwp-content%2fuploads%2f2017%2f12%2foutput_66_1.png&ehk=rEEFb6FVnqW8gaAadWW9kmBrhdxuzUm2axZ5lZIVlLA%3d&risl=&pid=ImgRaw&r=0"    width="400" height="200" />

## User Interface based
Given the protein structure the model will generate candidate drug.
### Step one
<img src="assets/step_1.PNG"    width="600" height="400" />
### Step Two
<img src="assets/step_2.PNG"    width="600" height="400" />

## But the work is in progress, there much more to do and contribute.
    
