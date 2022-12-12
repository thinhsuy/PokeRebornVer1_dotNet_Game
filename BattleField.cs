using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PokeWar
{
    public partial class BattleField : Form
    {
        List<string> A = new List<string>();
        List<string> B = new List<string>();
        List<Pokemon> TeamA = new List<Pokemon>();
        List<Pokemon> TeamB = new List<Pokemon>();
        List<PictureBox> ListPbPokemon = new List<PictureBox>();
        List<PictureBox> ListPbContainer = new List<PictureBox>();
        List<Pokemon> Queue = new List<Pokemon>();
        Dictionary<string, ProgressBar> DicHPbar = new Dictionary<string, ProgressBar>();
        string target = "", useSkill = "";
        int currentPos = 0;
        int boxWidth = 150, boxHeight = 150, timing = 0;
        bool isWait = false;
        int indexTarget = 0;

        public BattleField(
            List<string> paraA, 
            List<string> paraB
            )
        {
            if ((paraA == null || paraB == null) || (paraA.Count!=paraB.Count)) this.Close();
            this.A = paraA;
            this.B = paraB;
            InitializeComponent();
            this.Screen.Name = "pbScreen";
            Screen.ImageLocation = @"D:\Sequence\Compilers\Winform\Projects\PokeWar\PokeWar\Source\Background\ForestBattleScreen.png";
            Screen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        ////////////////////  FORM SET UP   ////////////////////////

        private void BattleField_Load(object sender, EventArgs e)
        {
            int posAx = 300, posAy = 30;
            int posBx = 0, posBy = this.Width / 3 - 50;


            for (int i=0; i<A.Count; i++)
            {
                posAx = Generate_Shape(A, "A", i, posAx, posAy, this.TeamA);
            }

            for (int i = 0; i < B.Count; i++)
            {
                posBx = Generate_Shape(B, "B", i, posBx, posBy, this.TeamB);
            }
            
            Timer.Start();
            FrameRate.Start();
        }

        private void pbSkillA_Click(object sender, EventArgs e)
        {
            cbSkillA.Checked = true;
            this.useSkill = tbSkillA.Text;
            if (cbSkillB.Checked || cbSkillC.Checked)
            {
                cbSkillB.Checked = false;
                cbSkillC.Checked = false;
            }
        }

        private void pbSkillB_Click(object sender, EventArgs e)
        {
            cbSkillB.Checked = true;
            this.useSkill = tbSkillB.Text;
            if (cbSkillA.Checked || cbSkillC.Checked)
            {
                cbSkillA.Checked = false;
                cbSkillC.Checked = false;
            }
        }

        private void pbSkillC_Click(object sender, EventArgs e)
        {
            cbSkillC.Checked = true;
            this.useSkill = tbSkillC.Text;
            if (cbSkillB.Checked || cbSkillA.Checked)
            {
                cbSkillB.Checked = false;
                cbSkillA.Checked = false;
            }
        }

        private void FrameRate_Tick(object sender, EventArgs e)
        {
            if (ListPbContainer[ListPbContainer.Count / 2].Location.X <= 50)
            {
                for(int i=0; i<ListPbContainer.Count; i++)
                {
                    if (i< ListPbContainer.Count / 2)
                        ListPbContainer[i].Location = new Point(ListPbContainer[i].Location.X - 2, ListPbContainer[i].Location.Y);
                    else
                        ListPbContainer[i].Location = new Point(ListPbContainer[i].Location.X + 2, ListPbContainer[i].Location.Y);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timing += 1;
            if (timing == 3)
            {
                for (int i = 0; i < TeamA.Count*2 ; i++)
                {
                    if (i < TeamA.Count) ListPbPokemon[i].ImageLocation = TeamA[i].Sources["Front"];
                    else ListPbPokemon[i].ImageLocation = TeamB[i-TeamA.Count].Sources["Back"];
                }
                timing = 0;
                Timer.Stop();
                onGame();
            }
        }

        private void PbContainer_Click(object sender, EventArgs e)
        {
            if (isWait == true) return;
            isWait = true;  
            if (!cbSkillA.Checked && !cbSkillB.Checked && !cbSkillC.Checked) return;
            foreach(PictureBox target in ListPbContainer) 
            {
                //if target is yourself
                if (sender==target && target.BorderStyle == BorderStyle.Fixed3D)
                {
                    target.BorderStyle = BorderStyle.None;
                    this.target = "";
                }
                //if target is others
                else if (sender == target)
                {
                    target.BorderStyle = BorderStyle.Fixed3D;
                    this.target = target.Name;
                    this.indexTarget = Queue.FindIndex(a => a.Name == target.Name);
                }
                else target.BorderStyle = BorderStyle.None;
            }
            cbSkillA.Checked = false;
            cbSkillB.Checked = false;
            cbSkillC.Checked = false;
            SkillOperation();
            NextTurn();
        }

        ///////////////////  GAME SET UP   ////////////////////////

        private string CheckIsEnd()
        {
            int countA = 0;
            int countB = 0;
            for (int i = 0; i<(Queue.Count/2)+1; i++)
            {
                if (Queue[i].CurrentTeam == "A") countA++;
                else countB++;
                if (countA >= 1 && countB >= 1) return "none";
            }
            if (countA == 0) return "B";
            else if (countB == 0) return "A";
            else return "none";
        }

        private int Generate_Shape(List<string>Team, string teamName, int i, int posX, int posY, List<Pokemon>TeamAdd) 
        {
            Pokemon poke = new Pokemon(Team[i]);
            poke.CurrentTeam = teamName;
            PictureBox pbContainer = new PictureBox();
            PictureBox pbPokemon = new PictureBox();
            pbContainer.Name = poke.Name;
            pbContainer.Width = this.boxWidth;
            pbContainer.Height = this.boxHeight;
            pbContainer.SizeMode = PictureBoxSizeMode.Normal;
            pbContainer.Padding = new Padding(0, pbContainer.Height - 50, 2, 0);
            pbContainer.BackColor = Color.Transparent;
            pbContainer.Location = new Point(posX, posY);
            pbContainer.ImageLocation = poke.Sources["Based"];
            pbContainer.Cursor = Cursors.Hand;
            pbContainer.Click += PbContainer_Click;
            pbPokemon.Name = "Poke" + teamName + i.ToString();
            pbPokemon.Width = this.boxWidth - 50;
            pbPokemon.Height = this.boxHeight - 50;
            pbPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPokemon.BackColor = Color.Transparent;
            pbPokemon.Location = new Point(pbContainer.Width / 2 - pbPokemon.Width / 2, pbContainer.Height / 2 - pbPokemon.Height / 2);
            posX += this.boxWidth;
            pbContainer.Controls.Add(pbPokemon);
            this.Screen.Controls.Add(pbContainer);
            TeamAdd.Add(poke);
            ListPbPokemon.Add(pbPokemon);
            ListPbContainer.Add(pbContainer);
            Queue.Add(poke);
            return posX;
        }

        private void NextTurn()
        {
            //increase current move for next pokemon
            this.currentPos++;
            if (this.currentPos >= Queue.Count)
                this.currentPos = 0;
            //reorder queue
            Queue = Queue.OrderByDescending(que => que.Speed).ToList();

            //mark that which pokemon is out
            foreach (PictureBox target in ListPbContainer)
            {
                if (DicHPbar[target.Name].Value == 0)
                {
                    target.Visible = false;
                    target.Enabled = false;
                    DicHPbar[target.Name].Visible = false;
                    DicHPbar[target.Name].Enabled = false;
                    //pop that target out of Queue
                    for (int i = 0; i < Queue.Count; i++)
                    {
                        if (Queue[i].Name == target.Name)
                        {
                            MessageBox.Show(Queue[i].Name + " is out of battle");
                            Queue.RemoveAt(i);
                            if (i < currentPos)
                                currentPos--;   
                        }
                    }
                    //check whether team win or not
                    string isEnd = CheckIsEnd();
                    if (isEnd != "none")
                    {
                        MessageBox.Show("Team " + isEnd + " win!");
                        this.Close();
                    }
                    continue;
                }
                if (target.Name == Queue[currentPos].Name) target.BorderStyle = BorderStyle.FixedSingle;
                else target.BorderStyle = BorderStyle.None;
            }
            
            //set up current pokemon's turn
            Load_Skill(currentPos);
            this.tbMention.Text += Environment.NewLine;
            this.tbMention.Text += "It's " + Queue[currentPos].Name + "'s Turn" + Environment.NewLine;

            //check out this pokemon's effect before move
            bool isCanMove = true;
            foreach (string harm in Queue[currentPos].HarmfulEffect.ToList())
            {
                if (harm == "Burn" || harm == "Poison")
                {
                    this.tbMention.Text += Queue[currentPos].Name + " loses HP due to " + harm + Environment.NewLine;
                    HPbarChange((int)Game.GetPercentage(5, Queue[currentPos].HP), Queue[currentPos].Name);
                }
                if (harm == "Stun" || harm=="Sleep" || harm=="Freezed")
                {
                    Queue[currentPos].HarmfulEffect.Remove(harm);
                    this.tbMention.Text += Queue[currentPos].Name + " is Stunned so it cant move!" + Environment.NewLine;
                    isCanMove = false;
                }
            }
            ConditionAbility(currentPos);


            //move text box
            this.tbMention.SelectionStart = this.tbMention.Text.Length;
            this.tbMention.ScrollToCaret();

            isWait = false;
            if (!isCanMove) NextTurn();
        }
  
        private void Generate_HPbar()
        {
            for (int i=0; i<ListPbContainer.Count; i++)
            {
                ProgressBar bar = new ProgressBar();
                bar.Location = new Point(ListPbContainer[i].Left, ListPbContainer[i].Top+ ListPbContainer[i].Height + 5);
                bar.Size = new Size(ListPbContainer[i].Width, 15);
                //check TeamA
                if (i < ListPbContainer.Count / 2)
                {
                    bar.Maximum = TeamA[i].HP;
                    bar.Value = TeamA[i].HP;
                } else //check TeamB
                {
                    bar.Maximum = TeamB[i-(ListPbContainer.Count/2)].HP;
                    bar.Value = TeamB[i-(ListPbContainer.Count/2)].HP;
                }
                bar.Name = "HPbar" + ListPbContainer[i].Name;
                DicHPbar.Add(ListPbContainer[i].Name, bar);
                this.Screen.Controls.Add(bar);
            }
        } 

        private void onGame()
        {
            Generate_HPbar();
            this.tbMention.Text = "Game Start" + Environment.NewLine;
            Queue = Queue.OrderByDescending(que => que.Speed).ToList();

            foreach (PictureBox target in ListPbContainer)
            {
                if (target.Name == Queue[currentPos].Name)
                {
                    target.BorderStyle = BorderStyle.FixedSingle;
                    break;
                }
            }
            EarlyAbilty_SetUp();
            Load_Skill(currentPos);
            this.tbMention.Text += "It's " + Queue[currentPos].Name + "'s Turn" + Environment.NewLine;
        }

        /////////////////////   ABILITY SET UP   /////////////////////////////
        private void EarlyAbilty_SetUp()
        {
            for (int i=0; i<Queue.Count; i++)
            {
                if (Queue[i].ability.Dimension == "Early" && !Queue[i].ability.isAbilityOperated)
                {
                    BeneficalEffect(i, Queue[i].ability.Effect, 0);
                    Queue[i].ability.isAbilityOperated = true;
                    this.tbMention.Text += Queue[i].Name + " active its Ability as " + Queue[i].ability.Name + Environment.NewLine; 
                }
            }
        }

        private void ConditionAbility(int victim)
        {
            if (Queue[victim].ability.Dimension != "Condition") return;
            if (Queue[victim].ability.Name == "Swarm" && !Queue[victim].ability.isAbilityOperated)
            {
                if (DicHPbar[Queue[victim].Name].Value <= (int)Game.GetPercentage(50, Queue[victim].HP))
                {
                    Queue[victim].ability.isAbilityOperated = true;
                    this.tbMention.Text += Queue[victim].Name + " active its Ability as " + Queue[victim].ability.Name + Environment.NewLine;
                    Queue[victim].ability.Name = Queue[victim].ability.Effect;
                }
            }
        }

        private void VampireAbility_SetUp(int damage)
        {
            if (Queue[currentPos].ability.Effect == "Vampire")
            {
                int heal = (int)Game.GetPercentage(10, damage) * (-1);
                HPbarChange(heal, Queue[currentPos].Name);
                this.tbMention.Text += Queue[currentPos].Name + " heal a little bit via its Ability" + Environment.NewLine;
            }
        }

        /////////////////////   EFFECTs SET UP   /////////////////////////////

        private void BeneficalEffect(int victim, string EffectName, int Amount)
        {
            if (EffectName == "Increase Physical")
                Queue[victim].Atk += (int)Game.GetPercentage(50, Queue[victim].Atk);
            else if (EffectName == "Increase Special")
                Queue[victim].SpAtk += (int)Game.GetPercentage(50, Queue[victim].SpAtk);
            else if (EffectName == "Increase Defense")
                Queue[victim].Def += (int)Game.GetPercentage(50, Queue[victim].Def);
            else if (EffectName == "Increase Special Defense")
                Queue[victim].SpDef += (int)Game.GetPercentage(50, Queue[victim].SpDef);
            else if (EffectName == "Strip Harmful")
                Queue[victim].HarmfulEffect.Clear();
            else if (EffectName == "Heal")
                HPbarChange(-(int)Game.GetPercentage(Amount*2, Queue[victim].HP), Queue[victim].Name);
            else if (EffectName == "Threat") {
                DicHPbar[Queue[victim].Name].Maximum += (int)Game.GetPercentage(50, Queue[victim].HP);
                DicHPbar[Queue[victim].Name].Value = DicHPbar[Queue[victim].Name].Maximum;
            }
        }

        private void HarmfulEffect(int victim, string EffectName, int Amount)
        {
            if (EffectName == "Slow")
                Queue[victim].Speed -= (int)Game.GetPercentage(30, Queue[victim].Speed);
            else if (EffectName == "Stun")  
                Queue[victim].HarmfulEffect.Add("Stun");
            else if (EffectName == "Decrease Physical")
                Queue[victim].Atk -= (int)Game.GetPercentage(50, Queue[victim].Atk);
            else if (EffectName == "Descrease Special")
                Queue[victim].SpAtk -= (int)Game.GetPercentage(50, Queue[victim].SpAtk);
            else if (EffectName == "Descrease Defense")
                Queue[victim].Def -= (int)Game.GetPercentage(50, Queue[victim].Def);
            else if (EffectName == "Descrease Special Defense")
                Queue[victim].SpDef -= (int)Game.GetPercentage(50, Queue[victim].SpDef);
            else if (EffectName == "Strip Benefical")
                Queue[victim].BeneficalEffect.Clear();
            else if (EffectName == "Recoil")
                HPbarChange((int)Game.GetPercentage(10, Queue[victim].HP) ,Queue[victim].Name);
            else if (EffectName == "Burn" || EffectName=="Poison")
                Queue[victim].HarmfulEffect.Add(EffectName);
        }

        private void ClassifyEffect(Effect eff, int victim)
        {
            if (eff.Type == "Harmful") HarmfulEffect(victim, eff.EffectName, eff.Portion);
            else BeneficalEffect(victim, eff.EffectName, eff.Portion);
        }
        
        private void EffectOperation_MultiTargets(Effect eff, string userTeam, string multiTargets)
        {
            for (int i=0; i<Queue.Count; i++)
            {
                if ((multiTargets == "Allies" && Queue[i].CurrentTeam == userTeam) ||
                    (multiTargets == "Enemies" && Queue[i].CurrentTeam != userTeam))
                {
                    ClassifyEffect(eff, i);
                }
            }
        }

        private void EffectOperation()
        {
            int victim = indexTarget;
            Skill skill = Queue[currentPos].Skills.Where(s => s.Name == useSkill).SingleOrDefault();
            foreach (Effect eff in skill.Effects)
            {
                if (Game.GetChance(eff.EffectRate) == false)
                {
                    this.tbMention.Text += "But " + Queue[currentPos].Name + " missed " + eff.EffectName + Environment.NewLine;
                    continue;
                }
                if (eff.EffectRange == "Single Target")
                    ClassifyEffect(eff, indexTarget);
                else if (eff.EffectRange == "Self")
                    ClassifyEffect(eff, currentPos);
                else if (eff.EffectRange == "AOE Targets")
                    EffectOperation_MultiTargets(eff, Queue[currentPos].CurrentTeam, "Enemies");
                else if (eff.EffectRange == "AOE Self")
                    EffectOperation_MultiTargets(eff, Queue[currentPos].CurrentTeam, "Allies");
                this.tbMention.Text += "Successfully apply " + eff.EffectName + Environment.NewLine;
            }
        }

        /////////////////////    SKILLs and ACTIONs SET UP      /////////////////////////////
     
        private void HPbarChange(int damage, string name) {
            if (DicHPbar[name].Value - damage < DicHPbar[name].Minimum) DicHPbar[name].Value = 0;
            else if (DicHPbar[name].Value - damage > DicHPbar[name].Maximum) DicHPbar[name].Value = DicHPbar[name].Maximum;
            else DicHPbar[name].Value -= damage;
        }

        private void Load_Skill(int pos)
        {
            try
            {
                tbSkillA.Text = Queue[pos].Skills[0].Name;
                tbSkillB.Text = Queue[pos].Skills[1].Name;
                tbSkillC.Text = Queue[pos].Skills[2].Name;
                pbSkillA.ImageLocation = Queue[pos].Sources["SkillA"];
                pbSkillB.ImageLocation = Queue[pos].Sources["SkillB"];
                pbSkillC.ImageLocation = Queue[pos].Sources["SkillC"];
                pbSkillA.SizeMode = PictureBoxSizeMode.StretchImage;
                pbSkillB.SizeMode = PictureBoxSizeMode.StretchImage;
                pbSkillC.SizeMode = PictureBoxSizeMode.StretchImage;
                ttSkillInfor.SetToolTip(pbSkillA, Queue[pos].Skills[0].Describe);
                ttSkillInfor.SetToolTip(pbSkillB, Queue[pos].Skills[1].Describe);
                ttSkillInfor.SetToolTip(pbSkillC, Queue[pos].Skills[2].Describe);
            } catch {
                return;
            }
        }

        private void SkillOperation_MultiTargets(string defender)
        {
            foreach (Pokemon target in Queue)
            {
                if (target.CurrentTeam == defender)
                {
                    (float amount, string notion) Damage = Skill.DamageCalculation(Queue[currentPos], useSkill, target);
                    HPbarChange((int)Damage.amount, target.Name);
                    //VampireAbility_SetUp((int)Damage.amount);
                    if (Damage.notion != "none" && Damage.notion!="Normal")
                        tbMention.Text += "It is " + Damage.notion + " to " + target.Name +Environment.NewLine;
                }
            }
        
        }

        private void SkillOperation()
        {
            Pokemon pokeTarget = Queue.Where(p => p.Name == target).FirstOrDefault();
            if (pokeTarget == null)
            {
                MessageBox.Show("Target is null");
                return;
            }
            Skill skill = Queue[currentPos].Skills.Where(s=>s.Name==useSkill).FirstOrDefault();
            //if damage == -1 means this is status skill
            if (skill.Kind=="Status")
                this.tbMention.Text += Queue[currentPos].Name + " using " + useSkill + " on " + target + Environment.NewLine; 
            else
            {
                //handle exception from user and set turn back
                if (Queue[currentPos].CurrentTeam == pokeTarget.CurrentTeam)
                {
                    MessageBox.Show("Cannot attack our ally");
                    this.currentPos -= 1;
                    return;
                }
                // if skill is single target
                if (skill.RangeSkill == "Single Target")
                {
                    (float amount, string notion) Damage = Skill.DamageCalculation(Queue[currentPos], useSkill, pokeTarget);
                    this.tbMention.Text += Queue[currentPos].Name + " using " + useSkill + " to attack " + target + Environment.NewLine;
                    //reduce target's hp bar
                    HPbarChange((int)Damage.amount, target);
                    //set up vampire effect
                    //VampireAbility_SetUp((int)Damage.amount);
                    if (Damage.notion != "none")
                        tbMention.Text += "It is " + Damage.notion + " to " + pokeTarget.Name + Environment.NewLine;
                } // if skill is AOE targets
                else if (skill.RangeSkill=="AOE Targets")
                {
                    this.tbMention.Text += Queue[currentPos].Name + " using " + useSkill + " to all enemies" + Environment.NewLine;
                    //if user is TeamA
                    if (Queue[currentPos].CurrentTeam == "A")
                        SkillOperation_MultiTargets("B");
                    //if user is TeamB
                    else SkillOperation_MultiTargets("A");
                }
            }
            EffectOperation();
        }
    }
}
        