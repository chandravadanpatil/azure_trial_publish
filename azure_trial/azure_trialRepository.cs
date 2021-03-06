///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace azure_trial
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
          /// <summary>
          /// The class representing the azure_trialRepository element repository.
          /// </summary>
          [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
          [RepositoryFolder("5c57bf02-91d7-48cb-b920-4b4acfc7dd1b")]
          public partial class azure_trialRepository : RepoGenBaseFolder
          {
                    static azure_trialRepository instance = new azure_trialRepository();
                    azure_trialRepositoryFolders.RxMainFrameAppFolder _rxmainframe;

                    /// <summary>
                    /// Gets the singleton class instance representing the azure_trialRepository element repository.
                    /// </summary>
                    [RepositoryFolder("5c57bf02-91d7-48cb-b920-4b4acfc7dd1b")]
                    public static azure_trialRepository Instance
                    {
                              get { return instance; }
                    }

                    /// <summary>
                    /// Repository class constructor.
                    /// </summary>
                    public azure_trialRepository() 
                              : base("azure_trialRepository", "/", null, 0, false, "5c57bf02-91d7-48cb-b920-4b4acfc7dd1b", ".\\RepositoryImages\\azure_trialRepository5c57bf02.rximgres")
                    {
                              _rxmainframe = new azure_trialRepositoryFolders.RxMainFrameAppFolder(this);
                    }

#region Variables

#endregion

                    /// <summary>
                    /// The Self item info.
                    /// </summary>
                    [RepositoryItemInfo("5c57bf02-91d7-48cb-b920-4b4acfc7dd1b")]
                    public virtual RepoItemInfo SelfInfo
                    {
                              get
                              {
                                        return _selfInfo;
                              }
                    }

                    /// <summary>
                    /// The RxMainFrame folder.
                    /// </summary>
                    [RepositoryFolder("c5ad41a6-3110-47c4-84e6-09f58a146a3b")]
                    public virtual azure_trialRepositoryFolders.RxMainFrameAppFolder RxMainFrame
                    {
                              get { return _rxmainframe; }
                    }
          }

          /// <summary>
          /// Inner folder classes.
          /// </summary>
          [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
          public partial class azure_trialRepositoryFolders
          {
                    /// <summary>
                    /// The RxMainFrameAppFolder folder.
                    /// </summary>
                    [RepositoryFolder("c5ad41a6-3110-47c4-84e6-09f58a146a3b")]
                    public partial class RxMainFrameAppFolder : RepoGenBaseFolder
                    {
                              RepoItemInfo _btnsubmitusernameInfo;
                              RepoItemInfo _enteryournameInfo;

                              /// <summary>
                              /// Creates a new RxMainFrame  folder.
                              /// </summary>
                              public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                                                  base("RxMainFrame", "/form[@automationid='RxMainFrame']", parentFolder, 30000, null, true, "c5ad41a6-3110-47c4-84e6-09f58a146a3b", "")
                              {
                                        _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", ".//button[@text='Submit']", ".//button[@text='Submit']", 30000, null, "c4157bfd-7e07-4da9-9459-f1ec6f3210ce");
                                        _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", ".//text[@accessiblename='Enter your name']", ".//text[@accessiblename='Enter your name']", 30000, null, "9c4ddcff-7d6e-4722-a704-a337c1dca273");
                              }

                              /// <summary>
                              /// The Self item.
                              /// </summary>
                              [RepositoryItem("c5ad41a6-3110-47c4-84e6-09f58a146a3b")]
                              public virtual Ranorex.Form Self
                              {
                                        get
                                        {
                                                  return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                                        }
                              }

                              /// <summary>
                              /// The Self item info.
                              /// </summary>
                              [RepositoryItemInfo("c5ad41a6-3110-47c4-84e6-09f58a146a3b")]
                              public virtual RepoItemInfo SelfInfo
                              {
                                        get
                                        {
                                                  return _selfInfo;
                                        }
                              }

                              /// <summary>
                              /// The BtnSubmitUserName item.
                              /// </summary>
                              [RepositoryItem("c4157bfd-7e07-4da9-9459-f1ec6f3210ce")]
                              public virtual Ranorex.Button BtnSubmitUserName
                              {
                                        get
                                        {
                                                  return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                                        }
                              }

                              /// <summary>
                              /// The BtnSubmitUserName item info.
                              /// </summary>
                              [RepositoryItemInfo("c4157bfd-7e07-4da9-9459-f1ec6f3210ce")]
                              public virtual RepoItemInfo BtnSubmitUserNameInfo
                              {
                                        get
                                        {
                                                  return _btnsubmitusernameInfo;
                                        }
                              }

                              /// <summary>
                              /// The EnterYourName item.
                              /// </summary>
                              [RepositoryItem("9c4ddcff-7d6e-4722-a704-a337c1dca273")]
                              public virtual Ranorex.Text EnterYourName
                              {
                                        get
                                        {
                                                  return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                                        }
                              }

                              /// <summary>
                              /// The EnterYourName item info.
                              /// </summary>
                              [RepositoryItemInfo("9c4ddcff-7d6e-4722-a704-a337c1dca273")]
                              public virtual RepoItemInfo EnterYourNameInfo
                              {
                                        get
                                        {
                                                  return _enteryournameInfo;
                                        }
                              }
                    }

          }
#pragma warning restore 0436
}
